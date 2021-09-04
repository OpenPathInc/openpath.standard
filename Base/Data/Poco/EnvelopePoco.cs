using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenPath.Standard.Base.Data.Poco {

    public class EnvelopePoco<T> where T : class {

        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("next_page")]
        public Uri NextPage { get; set; }

        [JsonProperty("last_page")]
        public Uri LastPage { get; set; }

        [JsonProperty("current_page")]
        public Uri CurrentPage { get; set; }

    }

}
