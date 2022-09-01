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
    public class SongManager : ISongService
    {
        public int Add(Song entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Song entity)
        {
            throw new NotImplementedException();
        }

        public Song Get(Expression<Func<Song, bool>> filter = null, Func<IQueryable<Song>, IIncludableQueryable<Song, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetAll(Expression<Func<Song, bool>> filter = null, Func<IQueryable<Song>, IIncludableQueryable<Song, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Song entity)
        {
            throw new NotImplementedException();
        }
    }
}
