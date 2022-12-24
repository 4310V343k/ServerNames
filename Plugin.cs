namespace ServerNames
{
    using System;

    using Exiled.API.Features;

    using Server = Exiled.Events.Handlers.Server;

    public class ServerNames : Plugin<Config>
    {
        private EventHandlers eventHandlers;
        public override string Author => "Remind me";
        public override string Name => "ServerNames";
        public override string Prefix => "Server Names";
        public override Version Version => new Version(1, 1, 0);
        public override Version RequiredExiledVersion => new Version(2, 3, 3);
        public static ServerNames Instance { get; } = new ServerNames();

        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers();
            Server.WaitingForPlayers += eventHandlers.OnWaitingForPlayers;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Server.WaitingForPlayers -= eventHandlers.OnWaitingForPlayers;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}
