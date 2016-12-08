﻿namespace Evaders.Server
{
    using System.Net;

    public class ServerSettings
    {
        public bool IsValid => (IP != null) && (MaxTimeInQueueSec > 0f) && (MaxUsernameLength > 0) && (GameModes != null) && (GameModes.Length > 0);

        public IPAddress IP { get; set; } = IPAddress.Parse("0.0.0.0");
        public float MaxTimeInQueueSec { get; set; } = 5f;
        public int MaxUsernameLength { get; set; } = 20;
        public string Motd { get; set; } = "Welcome :)";
        public ushort Port { get; set; } = 9090;
        public ushort BSONPort { get; set; } = 9091;
        public string[] GameModes { get; set; } = { "Default" };
    }
}