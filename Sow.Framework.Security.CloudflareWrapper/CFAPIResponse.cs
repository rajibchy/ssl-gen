﻿//2:40 AM 9/14/2018 Rajib
namespace Sow.Framework.Security.CloudflareWrapper {
    // "errors":[{"code":10000,"message":"Authentication error"}]
    public class CFAPIResponse : ICFAPIResponse {
        public object result { get; set; }
        public bool success { get; set; }
        public object errors { get; set; }
        public object messages { get; set; }

    }
}
