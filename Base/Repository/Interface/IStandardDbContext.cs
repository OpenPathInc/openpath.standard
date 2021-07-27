using Microsoft.EntityFrameworkCore;
using OpenPath.Standard.Base.Data.Database;

namespace OpenPath.Standard.Base.Repository.Interface {

    public interface IStandardDbContext {

        DbSet<PlanetModel> Planets { get; }

    }

}
