using System.Collections.Generic;
using System.Threading.Tasks;

namespace QueenKayShirt
{
    public class TDatabase
    {
      
        public TDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TInfo>().Wait();
        }
        public Task<List<TInfo>> GetItemsAsync()
        {
            return database.Table<TInfo>().ToListAsync();
        }
        public Task<List<TInfo>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<TInfo>("SELECT * FROM [Info]");
        }
        public Task<TInfo> GetItemAsync(int id)
        {
            return database.Table<TInfo>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> InsertTShirtOrder(TInfo info)
        {
            return database.InsertAsync(info);
        }
        public Task<int> UpdateTShirtOrder(TInfo info)
        {
            return database.UpdateAsync(info);
        }
        public Task<int> SaveTShirtOrder(TInfo item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteItemAsync(TInfo item)
        {
            return database.DeleteAsync(item);
        }



    }
}
