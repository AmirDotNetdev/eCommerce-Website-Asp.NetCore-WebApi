using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using tamrin2.Models;

namespace tamrin2.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T> GetAsync(Expression<Func<T,bool>>);
    }
}