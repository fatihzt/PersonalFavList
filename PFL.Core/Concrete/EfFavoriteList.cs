using PFL.Core.Abstract;
using PFL.Core.EntityFramework;
using PFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Core.Concrete
{
    public class EfFavoriteList:EfEntityRepositoryBase<FavoriteList,DatabaseContext>,IFavoriteList
    {
    }
}
