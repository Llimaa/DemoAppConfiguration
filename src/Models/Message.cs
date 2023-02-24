using AppConfiguration.Models;
using Microsoft.Extensions.Options;

namespace AppConfiguration.Models;

public class Message 
{
    private SettingsBeta settingsBeta { get; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }
    
    public Message(IOptionsSnapshot<SettingsBeta> options) 
    {
        settingsBeta = options.Value;
        SetMessage();
    } 

    public Message(string? title, string? description)
    {
        Title = title;
        Description = description;
    }

    private Message SetMessage() 
    {
        if(settingsBeta.Show) 
        {
            Title ="Visualização Beta...";
            Description = "Interface em teste para melhorar a usabilidade!";
            return this;
        }

        Title ="Visualização Padrão";
        Description = "Interface com a visualização Padrão";
        return this;
    }
}
