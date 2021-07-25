using Newtonsoft.Json;
using OpenPath.Standard.Base.Data.Abstract;
using OpenPath.Standard.Base.Data.Enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Data.Poco {

    public class PlanetFilterPoco : FilterAbstract {

        public PlanetSizeEnum? PlanetSize { get; set; }
        
        public double? EquatorialDiameterMinimum { get; set; }

        public double? EquatorialDiameterMaximum { get; set; }

        public override object Clone() {

            var jsonString = JsonConvert.SerializeObject(this);  
            return JsonConvert.DeserializeObject(jsonString,this.GetType()); 

        }

        public override object Clone(int page) {

            var jsonString = JsonConvert.SerializeObject(this);
            var clone = JsonConvert.DeserializeObject<PlanetFilterPoco>(jsonString);

            clone.Page += page;

            return clone;

        }

    }

}
