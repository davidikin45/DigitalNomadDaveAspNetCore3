using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DND.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DND.Web.Areas.Identity.Pages.Manage
{
    public class DownloadPersonalDataModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly ILogger<DownloadPersonalDataModel> _logger;
        private readonly JsonOptions _jsonOptions;

        public DownloadPersonalDataModel(
            UserManager<User> userManager,
            ILogger<DownloadPersonalDataModel> logger,
            IOptions<JsonOptions> jsonOptions)
        {
            _userManager = userManager;
            _logger = logger;
            _jsonOptions = jsonOptions.Value;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            _logger.LogInformation("User with ID '{UserId}' asked for their personal data.", _userManager.GetUserId(User));

            // Only include personal data for download
            var personalData = new Dictionary<string, string>();
            var personalDataProps = typeof(User).GetProperties().Where(
                            prop => Attribute.IsDefined(prop, typeof(PersonalDataAttribute)));
            foreach (var p in personalDataProps)
            {
                personalData.Add(p.Name, p.GetValue(user)?.ToString() ?? "null");
            }

            Response.Headers.Add("Content-Disposition", "attachment; filename=PersonalData.json");
            return new FileContentResult(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(personalData, _jsonOptions.JsonSerializerOptions)), "text/json");
        }
    }
}
