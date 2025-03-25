public class ServerConnection : IPrototype<ServerConnection>
{
    public string IP { get; set; }
    public int Port { get; set; }

    public ServerConnection(string ip, int port)
    {
        IP = ip;
        Port = port;
    }

    public ServerConnection Clone()
    {
        return new ServerConnection(IP, Port);
    }
}