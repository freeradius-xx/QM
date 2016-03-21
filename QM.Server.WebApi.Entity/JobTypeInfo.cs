﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QM.Server.WebApi.Entity {
    public class JobTypeInfo {

        public string FullName { get; set; }

        public string AssemblyQualifiedName { get; set; }

        public string AssemblyFile { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public IEnumerable<JobParameterInfo> Params { get; set; }
    }
}
