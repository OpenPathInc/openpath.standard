using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Utility.Repository.Helper {

    public static class DataHelper {

        public static T CompareAndReplace<T>(object existingObject, object newObject) {

            if (existingObject == newObject) return (T)existingObject;
            else return (T)newObject;

        }

    }

}
