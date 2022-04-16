using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SABlues.Models;
using SABlues.Services;

namespace SABlues.Pages.Pupps
{
    public class GLitterModel : PageModel
    {
        private readonly ILogger<GLitterModel> _logger;
        public JsonFilePuppiesServices PuppiesServices;
        public IEnumerable<Puppies> Puppies { get; private set; }

        public GLitterModel(
            ILogger<GLitterModel> logger,
            JsonFilePuppiesServices puppiesServices)
        {
            _logger = logger;
            PuppiesServices = puppiesServices;
        }

        public void OnGet()
        {
            Puppies = PuppiesServices.GetPuppiesByLitter();
        }
    }
}
