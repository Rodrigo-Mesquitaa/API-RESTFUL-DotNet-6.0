using System.Collections.Generic;

namespace RegionAPI.Repositories
{
    public interface IRepository<TModel>
    {
        IEnumerable<TModel> GetAll();
        TModel GetSingle(int id);
        TModel Add(TModel toAdd);
        TModel Update(TModel toUpdate);
        void Delete(TModel toDelete);
        int Save();

    }
}
