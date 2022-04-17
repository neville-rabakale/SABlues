using Microsoft.AspNetCore.Hosting;
using SABlues.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace SABlues.Services
{
    public class JsonFileEntryServices
    {
        public JsonFileEntryServices(IWebHostEnvironment webHostEnviroment)
        {
            WebHostEnviroment = webHostEnviroment;
        }

        public IWebHostEnvironment WebHostEnviroment { get; }


        //--------- Below is the file Names/path to be used to extract the json files ---------

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "AboutUs.json"); }
        }
 
        //The function to do the extracting using the path
        public IEnumerable<PageEntry> GetAboutUsEntry()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<PageEntry[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        //TODO: Makt it accept special charectors : Swedish/Norsk
                        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                        WriteIndented = true
                    });
            }
        }

    }
}
