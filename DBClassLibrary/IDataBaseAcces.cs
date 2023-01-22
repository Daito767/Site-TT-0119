using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBLibrary
{
    public interface IDataBaseAcces
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}