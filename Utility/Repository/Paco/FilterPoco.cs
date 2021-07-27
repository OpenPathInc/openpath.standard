using Newtonsoft.Json;
using OpenPath.Utility.Repository.Abstract;

namespace OpenPath.Utility.Repository.Poco {

    public class FilterPoco : FilterAbstract {

        public override object Clone() {

            var jsonString = JsonConvert.SerializeObject(this);  
            return JsonConvert.DeserializeObject(jsonString,this.GetType()); 

        }

        public override object Clone(int page) {

            var jsonString = JsonConvert.SerializeObject(this);
            var clone = JsonConvert.DeserializeObject<FilterPoco>(jsonString);

            clone.Page += page;

            return clone;

        }

    }

}
