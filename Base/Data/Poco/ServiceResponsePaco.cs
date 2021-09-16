using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Data.Poco {

    public class ServiceResponsePaco {

        public IEnumerable<long> UpdatedIds { get; set; }

        public IEnumerable<long> CreatedIds { get; set; }

        public IEnumerable<long> DeletedIds { get; set; }

        public long RecordsUpdated { get; set; }

        public bool HasUpdates {
            get {

                if (UpdatedIds == null) return false;

                return UpdatedIds.Count() > 0;

            }
        }

        public bool HasCreated {
            get {

                if (CreatedIds == null) return false;

                return CreatedIds.Count() > 0;

            }
        }

        public bool HasDeleted {
            get {

                if (DeletedIds == null) return false;

                return DeletedIds.Count() > 0;

            }
        }

        public bool HasCreatedOnly {
            get {
                return HasCreated && !HasUpdates;
            }
        }

        public bool HasUpdatedOnly {
            get {
                return !HasCreated && HasUpdates;
            }
        }

        public bool HasCreatedAndUpdated {
            get {
                return HasCreated && HasUpdates;
            }
        }

    }

}
