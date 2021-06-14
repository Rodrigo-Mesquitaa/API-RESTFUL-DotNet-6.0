using RegionAPI.Data;
using RegionAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegionAPI.Repositories
{
    public class CountryRepository : IRepository<CountryModel>
    {
        private readonly DataBaseContext _DbContex;

        public CountryRepository(DataBaseContext dbcontext)
        {
            _DbContex = dbcontext;
        }
        public CountryModel Add(CountryModel toAdd)
        {
            _DbContex.Countries.Add(toAdd);
            return toAdd;
        }

        public void Delete(CountryModel toDelete)
        {
            _DbContex.Countries.Remove(toDelete);
        }

        public IEnumerable<CountryModel> GetAll()
        {
            return _DbContex.Countries;
        }

        public CountryModel GetSingle(int id)
        {
            return _DbContex.Countries.FirstOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return _DbContex.SaveChanges();
        }

        public CountryModel Update(CountryModel toUpdate)
        {
            _DbContex.Countries.Update(toUpdate);
            return toUpdate;
        }
    }
}
