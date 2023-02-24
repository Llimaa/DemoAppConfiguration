using AppConfiguration.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace AppConfiguration.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public Message Message { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IOptionsSnapshot<SettingsBeta> options)
    {
        _logger = logger;
        this.Message = new Message(options);
    }

}
