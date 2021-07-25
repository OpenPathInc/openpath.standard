using OpenPath.Standard.Base.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Data.Abstract {

    public abstract class FilterAbstract : IFilter, ICloneable {

        public int Page { get; set; } = 1;

        public int Limit { get; set; } = 20; 
  
        public abstract object Clone();

        public abstract object Clone(int page);

    }

}
