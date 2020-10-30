using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CargoRocketFontes.Classes
{
    public enum SourceCompareOptions
    {
        DEFAULT = 0,
        DISCARD_SECONDS,
        DISCARD_HOUR
    }


    public class SourceCompare
    {
        public event Action<int,int> ProgressInitialize;
        public event Action<int> ProgressChanged;

        public SourceCompare()
        {

        }

        public SourceCompareResult Run(string repository, string sourcesFile, SourceCompareOptions options, string pattern = "*.*")
        {
            SourceCompareResult result = new SourceCompareResult();
            string[] repositoryFiles;
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
                        s.Filename = sourceInfo[0];
                        s.Date = date.ToShortDateString();
                        s.Hour = sourceInfo[2];
                        sources.Add(s);
                    }

                }
            }

            repositoryFiles = Directory.GetFiles(repository, pattern, SearchOption.AllDirectories);
            result.totalSourceRepository = repositoryFiles.Length;

            OnProgressInitialize(0, repositoryFiles.Length -1);

            for (int i = 0; i < repositoryFiles.Length; i++)
            {
                OnProgressChanged(i);
                string filename = Path.GetFileName(repositoryFiles[i]).ToLower();
                string fullFilename = repositoryFiles[i];
                DateTime fileModification = File.GetLastWriteTime(repositoryFiles[i]);
                string dateRepository = fileModification.ToShortDateString();
                string hourRepository = fileModification.ToLongTimeString();
                bool diff = false;

                Source s = sources.Find(x => x.Filename.ToLower() == filename);
                if (s.Filename == null)
                {
                    Source sourceNonExistent = new Source();
                    sourceNonExistent.Filename = filename;
                    sourceNonExistent.FullFilename = fullFilename;
                    sourceNonExistent.Date = dateRepository;
                    sourceNonExistent.Hour = hourRepository;
                    result.sourceNonExistent.Add(sourceNonExistent);
                }
                else
                {
                    if (dateRepository == s.Date)
                    {
                        if (options == SourceCompareOptions.DEFAULT)
                        {
                            if (hourRepository != s.Hour)
                            {
                                diff = true;
                            }
                        }
                        else if (options == SourceCompareOptions.DISCARD_SECONDS)
                        {
                            if (hourRepository.Substring(0, 5) != s.Hour.Substring(0, 5))
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
                        sourceDiff.Filename = filename;
                        sourceDiff.FullFilename = fullFilename;
                        sourceDiff.DateRPO = s.Date;
                        sourceDiff.HourRPO = s.Hour;
                        sourceDiff.DateRepository = dateRepository;
                        sourceDiff.HourRepository = hourRepository;
                        sourceDiff.DateTimeRPO = StringToDateTime(sourceDiff.DateRPO, sourceDiff.HourRPO);
                        sourceDiff.DateTimeRepository = StringToDateTime(sourceDiff.DateRepository, sourceDiff.HourRepository);

                        result.sourceDiff.Add(sourceDiff);
                    }

                }
            }

            return result;
        }

        private DateTime StringToDateTime(string date, string time)
        {
            DateTime ret;
            int year, month, day;
            int hour, min, sec;

            year = Convert.ToInt32(date.Substring(6, 4));
            month = Convert.ToInt32(date.Substring(3, 2));
            day = Convert.ToInt32(date.Substring(0, 2));
            hour = Convert.ToInt32(time.Substring(0, 2));
            min = Convert.ToInt32(time.Substring(3, 2));
            if (time.Length >= 6)
            {
                sec = Convert.ToInt32(time.Substring(6, 2));
            }
            else
            {
                sec = 0;
            }
           

            ret = new DateTime(year, month, day, hour, min, sec);
            return ret;
        }

        private void OnProgressInitialize(int min, int max)
        {
            var eh = ProgressInitialize;
            if (eh != null)
            {
                eh(min, max);
            }
        }


        private void OnProgressChanged(int progress)
        {
            var eh = ProgressChanged;
            if (eh != null)
            {
                eh(progress);
            }
        }

    }
}
