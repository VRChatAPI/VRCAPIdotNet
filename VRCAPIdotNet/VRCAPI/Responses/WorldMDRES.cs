﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using VRCAPIdotNet.VRCAPI.Endpoints;
using VRCAPIdotNet.VRCAPI.Responses;
using VRCAPIdotNet.VRCAPI;

namespace VRCAPIdotNet.VRCAPI.Responses
{
    public class WorldMDRES
    {
        public string id { get; set; }
        public JObject metadata { get; set; }
    }
}
