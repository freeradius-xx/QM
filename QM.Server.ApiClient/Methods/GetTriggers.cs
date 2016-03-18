﻿using QM.Server.WebApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QM.Server.ApiClient.Methods {
    public class GetTriggers : BaseMethod<IEnumerable<TriggerInfo>> {
        public override HttpMethod HttpMethod {
            get {
                return HttpMethod.Get;
            }
        }

        public override string Model {
            get {
                return "Triggers";
            }
        }
    }
}