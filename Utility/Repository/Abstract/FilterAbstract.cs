using System;
using Newtonsoft.Json;
using OpenPath.Utility.Repository.Interface;

namespace OpenPath.Utility.Repository.Abstract {

    public abstract class FilterAbstract : IFilter, ICloneable {

        [JsonProperty("page")]
        public int Page { get; set; } = 1;

        [JsonProperty("limit")]
        public int Limit { get; set; } = 20; 
  
        public abstract object Clone();

        public abstract object Clone(int page);

    }

}
