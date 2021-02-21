using Exiled.API.Features;

namespace ServerNames
{
    public class EventHandlers
    {
        public void OnWaitingForPlayers() => Server.Name = ServerNames.Instance.Config.Name ?? Server.Name;
    }
}
