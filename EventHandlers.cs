namespace ServerNames
{
    using Exiled.API.Features;

    public class EventHandlers
    {
        public void OnWaitingForPlayers()
        {
            Server.Name = ServerNames.Instance.Config.Name ?? Server.Name;
        }
    }
}
