using Microsoft.AspNetCore.Hosting;
using SABlues.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SABlues.Services
{
    public class JsonFilePuppiesServices
    {
        public JsonFilePuppiesServices(IWebHostEnvironment webHostEnviroment)
        {
            WebHostEnviroment = webHostEnviroment;
        }

        public IWebHostEnvironment WebHostEnviroment { get; }

        private string JsonFileNames
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "litters.json"); }
        }

        //--------- Below are the file Names to be used to extract the json files ---------

        //JsonFileName = Glitter
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "puppies.json"); }
        }
        private string ABBAlitter
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "ABBAlitter.json"); }
        }
        private string Blitter
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "Blitter.json"); }
        }
        private string Clitter
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "Clitter.json"); }
        }
        private string Dlitter
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "Dlitter.json"); }
        }
        private string Slitter
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "Slitter.json"); }
        }
        private string OurBedlingtons
        {
            get { return Path.Combine(WebHostEnviroment.WebRootPath, "data", "OurBedlingtons.json"); }
        }




        //These functions do the extracting using the file names above
        public IEnumerable<Puppies> GetClitter()
        {
            using (var jsonFileReader = File.OpenText(Clitter))
            {
                return JsonSerializer.Deserialize<Puppies[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false
                    });
            }
        }

        public IEnumerable<Puppies> GetABBAlitter()
        {
            using (var jsonFileReader = File.OpenText(ABBAlitter))
            {
                return JsonSerializer.Deserialize<Puppies[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false
                    });
            }
        }

        public IEnumerable<Puppies> GetBlitter()
        {
            using (var jsonFileReader = File.OpenText(Blitter))
            {
                return JsonSerializer.Deserialize<Puppies[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false
                    });
            }
        }

        public IEnumerable<Puppies> GetDlitter()
        {
            using (var jsonFileReader = File.OpenText(Dlitter))
            {
                return JsonSerializer.Deserialize<Puppies[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false
                    });
            }
        }

        public IEnumerable<Puppies> GetSlitter()
        {
            using (var jsonFileReader = File.OpenText(Slitter))
            {
                return JsonSerializer.Deserialize<Puppies[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false
                    });
            }
        }
        public IEnumerable<Puppies> GetOurBedlingtons()
        {
            using (var jsonFileReader = File.OpenText(OurBedlingtons))
            {
                return JsonSerializer.Deserialize<Puppies[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false
                    });
            }
        }

        //GetPuppiesByLitter = Glitter
        public IEnumerable<Puppies> GetPuppiesByLitter()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Puppies[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }


        //Gets all the litters
        public IEnumerable<PuppyLitters> GetLitters()
        {
            using (var jsonFileReader = File.OpenText(JsonFileNames))
            {
                return JsonSerializer.Deserialize<PuppyLitters[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false
                    });
            }
        }



    }
}
