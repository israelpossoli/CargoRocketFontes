using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoRocketFontes.Classes
{
    public class Config
    {
        public static string Version = "2020-10-26";
        public string RepositoryPath;

        public Config()
        {
            RepositoryPath = @"C:\Cargolift\SVN\Protheus\trunk\V12\PROTHEUS12";
        }

        public static Config Load()
        {
            if (File.Exists(@"config.cfg"))
            {
                using (StreamReader r = new StreamReader(@"config.cfg"))
                {
                    string json = r.ReadToEnd();
                    // List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                    return JsonConvert.DeserializeObject<Config>(json);
                }
            }
            else
            {
                return new Config();
            }

        }

        public void Save()
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(@"config.cfg"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}
