using Newtonsoft.Json;
using OpenPath.Standard.Base.Data.Abstract;
using OpenPath.Standard.Base.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Data.Poco {

    public class FilterPoco : FilterAbstract {

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
