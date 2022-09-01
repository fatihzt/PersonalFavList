using Microsoft.EntityFrameworkCore.Query;
using PFL.Business.Abstract;
using PFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        public int Add(FavoriteList entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(FavoriteList entity)
        {
            throw new NotImplementedException();
        }

        public FavoriteList Get(Expression<Func<FavoriteList, bool>> filter = null, Func<IQueryable<FavoriteList>, IIncludableQueryable<FavoriteList, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public List<FavoriteList> GetAll(Expression<Func<FavoriteList, bool>> filter = null, Func<IQueryable<FavoriteList>, IIncludableQueryable<FavoriteList, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(FavoriteList entity)
        {
            throw new NotImplementedException();
        }
    }
}
