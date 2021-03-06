﻿using System;
using System.Reflection;
using Servant.Business.Objects;

namespace Servant.Client.Infrastructure
{
    public class ServantClientConfiguration
    {
        public ServantVersion Version;

        public ServantClientConfiguration()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            Version = new ServantVersion(version.Major, version.Minor, version.Build);
        }

        public Guid InstallationGuid { get; set; }
        public string ServantIoKey { get; set; }
        public string ServantIoHost { get; set; }
        public bool DisableConsoleAccess { get; set; }
    }
}