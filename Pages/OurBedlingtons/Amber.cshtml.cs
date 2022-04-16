using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SABlues.Models;
using SABlues.Services;
using System.Collections.Generic;

namespace SABlues.Pages.OurBedlingtons
{
    public class AmberModel : PageModel
    {
        private readonly ILogger<AmberModel> _logger;
        public JsonFilePuppiesServices PuppiesServices;
        public IEnumerable<Puppies> OurBedlingtons { get; private set; }

        public AmberModel(
            ILogger<AmberModel> logger,
            JsonFilePuppiesServices puppiesServices)
        {
            _logger = logger;
            PuppiesServices = puppiesServices;
        }

        public void OnGet()
        {
            OurBedlingtons = PuppiesServices.GetOurBedlingtons();
        }
    }
}
