﻿namespace LocalIdentity.SimpleInfra.Infrastructure.Settings;

public class RabbitMqConnectionSettings
{
    public string HostName { get; set; } = default!;

    public int Port { get; set; }
}