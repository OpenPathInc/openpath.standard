using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Data.Poco {

    public class EnvelopePoco<T> where T : class {

        public IEnumerable<T> Data { get; set; }
        public Uri NextPage { get; set; }
        public Uri PreviousPage { get; set; }

    }

}
