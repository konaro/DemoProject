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
    }
}