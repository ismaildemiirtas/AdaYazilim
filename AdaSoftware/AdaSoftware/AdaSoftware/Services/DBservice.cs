using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AdaSoftware.Database;
using System.Threading.Tasks;

namespace AdaSoftware.Services
{
    public class DBservice
    {
        private SQLiteAsyncConnection database;

        public SQLiteAsyncConnection Database { get => database; set => database = value; }

        public DBservice (string path)
        {
            Database = new SQLiteAsyncConnection(path);
            Database.CreateTableAsync<USER>();
            Database.CreateTableAsync<Insurance>();
        }
        public Task<int> AddInsurance(Insurance insurance)
        {
            return Database.InsertAsync(insurance);

        }

        public Task<List<Insurance>> GetInsurances()
        {
            return Database.Table<Insurance>().ToListAsync();
        }

        public Task<int> DeleteInsurance(int id)
        {
            return Database.DeleteAsync(id);
        }

        public Task<USER> GetUserByName(string username)
        {
            return Database.Table<USER>().Where(i => i.USERNAME.Equals(username)).FirstOrDefaultAsync();
        }
        public Task<int> AddUser(USER user)
        {
            if(user.USERID == 0)
            {
                return Database.InsertAsync(user);
            } 
            else
            {
                return Database.UpdateAsync(user);
            }
        }
        public Task<USER> LoginFunction(string username, string password)
        {
            return Database.Table<USER>().Where(x => x.USERNAME.Equals(username) && x.PASSWORD.Equals(password)).FirstOrDefaultAsync();
        }

        internal Task<List<Insurance>> getInsurances()
        {
            throw new NotImplementedException();
        }
    }
}
