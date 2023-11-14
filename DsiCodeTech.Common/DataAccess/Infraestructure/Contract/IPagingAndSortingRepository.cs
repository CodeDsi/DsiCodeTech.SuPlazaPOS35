using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DsiCodeTech.Common.DataAccess.Infraestructure.Contract
{
    public interface IPagingAndSortingRepository<T>
    {
        int Count(Expression<Func<T, bool>> where);

        IEnumerable<T> GetPaging<TKey>(Expression<Func<T, TKey>> orderBy, int page_number, int page_size);

        IEnumerable<T> GetPaging<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, int page_number, int page_size);

        IEnumerable<T> GetPagingDescending<TKey>(Expression<Func<T, TKey>> orderBy, int page_number, int page_size);

        IEnumerable<T> GetPagingDescending<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, int page_number, int page_size);

    }
}
