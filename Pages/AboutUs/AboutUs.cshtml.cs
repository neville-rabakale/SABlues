using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SABlues.Models;
using SABlues.Services;

namespace SABlues.Pages.AboutUs
{
    public class AboutUsModel : PageModel
    {

        private readonly ILogger<AboutUsModel> _logger;
        public JsonFileEntryServices _fileEntry;

        public IEnumerable<PageEntry> aboutUs { get; private set; }
    //    public IEnumerable<PageEntry> StraboutUs { get; private set; }


        public AboutUsModel(
            ILogger<AboutUsModel> logger,
            JsonFileEntryServices fileEntry)
        {
            _logger = logger;
            _fileEntry = fileEntry;
        }

        public void OnGet()
        {
            aboutUs = _fileEntry.GetAboutUsEntry();
        }

    }
}
