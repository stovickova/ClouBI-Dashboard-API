using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    /// <summary>
    /// Interface vyžadující základní ReadOnly metody repository.
    /// </summary>
    /// <typeparam name="TId">Typ Id entity</typeparam>
    /// <typeparam name="TEntity">Typ entity</typeparam>
    /// <typeparam name="TBusiness">Typ business objektu, který je promappovát s entitou</typeparam>
    public interface IReadOnlyRepositoryBase<TId, TEntity, TBusiness>
    {
        /// <summary>
        /// Metoda pro získání všech objektů.
        /// </summary>
        /// <returns>Kolekci business objektů</returns>
        IEnumerable<TBusiness> GetAll();

        /// <summary>
        /// Asynchronní metoda pro získání všech objektů.
        /// </summary>
        /// <returns>Kolekci business objektů</returns>
        Task<IEnumerable<TBusiness>> GetAllAsync();


        /// <summary>
        /// Metoda pro získání všech vyfiltrovaných objektů podmínkou
        /// </summary>
        /// <returns>Kolekci business objektů</returns>
        IEnumerable<TBusiness> GetByExpression(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Asynchronní metoda pro získání všech vyfiltrovaných objektů podmínkou
        /// </summary>
        /// <returns>Kolekci business objektů</returns>
        Task<IEnumerable<TBusiness>> GetByExpressionAsync(Expression<Func<TEntity, bool>> expression);


        /// <summary>
        /// Metoda pro získání prvního vyfiltrovaného objektu podmínkou.
        /// </summary>
        /// <param name="expression">Podmínka</param>
        /// <returns>Business objekt</returns>
        TBusiness FindByExpression(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Asynchronní metoda pro získání prvního vyfiltrovaného objektu podmínkou.
        /// </summary>
        /// <param name="expression">Podmínka</param>
        /// <returns>Business objekt</returns>
        Task<TBusiness> FindByExpressionAsync(Expression<Func<TEntity, bool>> expression);
    }
}
