using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleApi.Models;

namespace VehicleApi.Repository
{

    public class VehicleRepository
    {

        private readonly VehicleContext _context = null;

        public VehicleRepository(VehicleContext context)
        {
            _context = context;
        }

        public IQueryable<Makes> GetVehicles()
        {
            return _context.Makes;
        }

        public IQueryable<MakesModels> GetVehiclesByMakeIdandModelId(int makebyid,int modelbyId)
        {
            // return _context.Makes;

            var makedmodelsdata = from a in _context.Makes
                                  join b in _context.Models
                                  on a.id equals b.makeId
                                  where a.id == makebyid && b.modelId== modelbyId
                                  // into Dep
                                  ////  from c in Dep.DefaultIfEmpty()
                                  select new MakesModels
                                  {
                                      ID = a.id,
                                      name = a.name,
                                      modelsname = b.name,
                                      modelId = b.modelId
                                  };

           return makedmodelsdata;
        }

        
    }
}
