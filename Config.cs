using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ServerNames
{
    public class Config : IConfig
    {
        [Description("Should the override be enabled?")]
        public bool IsEnabled { get; set; } = false;
        
        [Description("If yes, what would the new server name be?")]
        public string Name { get; set; } = "Example";
        
        public bool Debug { get; set; } = false;
    }
}
