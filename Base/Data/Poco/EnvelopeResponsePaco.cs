using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Software.Standard.Base.Data.Poco {

    public class EnvelopeResponsePaco {

        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public IEnumerable<string> ErrorMessages { get; set; }

    }

}
