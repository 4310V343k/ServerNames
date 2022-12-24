namespace ServerNames
{
    using System.ComponentModel;

    using Exiled.API.Interfaces;

    public class Config : IConfig
    {
        [Description("If yes, what would the new server name be?")]
        public string Name { get; set; } = "Example";

        [Description("Should the override be enabled?")]
        public bool IsEnabled { get; set; } = false;

        public bool Debug { get; set; } = false;
    }
}
