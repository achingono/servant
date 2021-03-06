﻿using System.Collections.Generic;

namespace Servant.Business.Objects
{
    public class AllResponse
    {
        public List<Site> Sites { get; set; }
        public List<ApplicationPool> ApplicationPools { get; set; }
        public List<Certificate> Certificates { get; set; }
        public List<string> FrameworkVersions { get; set; }
    }
}