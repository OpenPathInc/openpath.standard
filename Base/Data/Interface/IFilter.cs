using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Data.Interface {
    public interface IFilter {

        int Page { get; set; }

        int Limit { get; set; } 

    }
}
