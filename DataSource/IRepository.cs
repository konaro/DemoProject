using System.Collections.Generic;

namespace DataSource
{
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// 查詢所有資料
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> ReadAll();

        /// <summary>
        /// 查詢特定資料 (By ids)
        /// </summary>
        /// <param name="condition">查詢條件</param>
        /// <returns></returns>
        IEnumerable<TEntity> ReadRowsByIds(List<TEntity> condition);
    }
}