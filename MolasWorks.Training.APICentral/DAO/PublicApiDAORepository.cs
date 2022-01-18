using MolasWorks.Training.APICentral.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MolasWorks.Training.APICentral.DAO
{
    public class PublicApiDAORepository
    {
        private readonly SQLiteAsyncConnection _database;

        public PublicApiDAORepository(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<APIEntity>().Wait();
        }

        public Task<List<APIEntity>> GetAll() {
            return _database.Table<APIEntity>().ToListAsync();
        }

        public Task<APIEntity> GetById(int id) {
            return _database.Table<APIEntity>().Where(api => api.Id == id).FirstOrDefaultAsync();
        }

        public void Add(APIEntity entity) {
            _database.InsertAsync(entity);
        }
    }
}
