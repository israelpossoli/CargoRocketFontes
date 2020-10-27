using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoRocketFontes.Classes
{
    public enum SourceCompareOptions
    {
        DEFAULT = 0,
        WITHOUT_SECONDS,
        DISCARD_HOUR
    }


    public class SourceCompare
    {

        public SourceCompare()
        {

        }

        public SourceCompareResult Run(string repository, string sourcesFile, SourceCompareOptions options, string pattern = "*.*")
        {
            SourceCompareResult result = new SourceCompareResult();
            string[] repositoryFiles = Directory.GetFiles(repository, pattern, SearchOption.AllDirectories);
            List<Source> sources = new List<Source>();

            string line;



            using (var sr = new StreamReader(sourcesFile))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "Fontes" || line == "Nome;Data;Hora")
                    {
                        continue;
                    }

                    string[] sourceInfo = line.Split(';');

                    if (sourceInfo.Length >= 3)
                    {

                        DateTime date = DateTime.Parse(sourceInfo[1]);
                        Source s = new Source();
                        s.filename = sourceInfo[0];
                        s.date = date.ToShortDateString();
                        s.hour = sourceInfo[2];
                        sources.Add(s);
                    }

                }


            }

            for (int i = 0; i < repositoryFiles.Length; i++)
            {
                string filename = Path.GetFileName(repositoryFiles[i]).ToLower();
                DateTime fileModification = File.GetCreationTime(repositoryFiles[i]);
                string dateRepository = fileModification.ToShortDateString();
                string hourRepository = fileModification.ToLongTimeString();
                bool diff = false;

                Source s = sources.Find(x => x.filename.ToLower() == filename);
                if (s.filename == null)
                {
                    Source sourceNonExistent = new Source();
                    sourceNonExistent.filename = filename;
                    sourceNonExistent.date = dateRepository;
                    sourceNonExistent.hour = hourRepository;
                    result.sourceNonExistent.Add(sourceNonExistent);
                }
                else
                {
                    if (dateRepository == s.date)
                    {
                        if (options == SourceCompareOptions.DEFAULT)
                        {
                            if (hourRepository != s.hour)
                            {
                                diff = true;
                            }
                        }
                        else if (options == SourceCompareOptions.WITHOUT_SECONDS)
                        {
                            if (hourRepository.Substring(0, 5) != s.hour.Substring(0, 5))
                            {
                                diff = true;
                            }
                        }
                    }
                    else
                    {
                        diff = true;
                    }

                    if (diff)
                    {
                        SourceDiff sourceDiff = new SourceDiff();
                        sourceDiff.filename = filename;
                        sourceDiff.DateRPO = s.date;
                        sourceDiff.HourRPO = s.hour;
                        sourceDiff.DateRepository = dateRepository;
                        sourceDiff.HourRepository = hourRepository;
                        result.sourceDiff.Add(sourceDiff);
                    }

                }
            }

            return result;

        }
    }
}
