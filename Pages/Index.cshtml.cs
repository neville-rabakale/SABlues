using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SABlues.Models;
using SABlues.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SABlues.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFilePuppiesServices PuppiesServices;
        public IEnumerable<PuppyLitters> Litters { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFilePuppiesServices puppiesServices)
        {
            _logger = logger;
            PuppiesServices = puppiesServices;
        }

        public void OnGet()
        {
            Litters = PuppiesServices.GetLitters();
        }
    }
}
