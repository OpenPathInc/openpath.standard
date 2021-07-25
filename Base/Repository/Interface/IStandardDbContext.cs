using Microsoft.EntityFrameworkCore;
using OpenPath.Standard.Base.Data.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Standard.Base.Repository.Interface {

    public interface IStandardDbContext {

        DbSet<PlanetModel> Planets { get; }

    }

}
