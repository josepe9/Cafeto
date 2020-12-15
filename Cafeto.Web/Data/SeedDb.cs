using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeto.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext context;

        public SeedDb(DataContext context)
        {
            this.context = context;
        }

        public async Task SeedAsync()
        {
            //EnsureCreatedAsync espera a que se cree la db
            await this.context.Database.EnsureCreatedAsync();
        }
    }
}
