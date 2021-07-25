using OpenPath.Standard.Base.Repository.Data;
using OpenPath.Standard.Base.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Repository {

    public class StandardUnitOfWork : IStandardUnitOfWork, IDisposable {

        private readonly StandardDbContext _standardDbContext;

        public StandardUnitOfWork(StandardDbContext standardDbContext) {

            _standardDbContext = standardDbContext;

            Planets = new PlanetRepository(_standardDbContext);

        }

        public IStandardDbContext DbContext => _standardDbContext;

        public IPlanet Planets { get; private set; }

        public int Commit() {

            return _standardDbContext.SaveChanges();

        }

        public async Task<int> CommitAsync() {
            
            return await _standardDbContext.SaveChangesAsync();

        }

        public void Dispose() {
        
            _standardDbContext.Dispose();

        }

        public async Task DisposeAsync() {
        
            await _standardDbContext.DisposeAsync();

        }

    }
}
