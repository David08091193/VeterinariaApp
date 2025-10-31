using SQLite;
using VeterinariaApp.Models;

namespace VeterinariaApp.Data
{
    public class MascotaDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public MascotaDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Mascota>().Wait();
        }

        public Task<int> GuardarMascotaAsync(Mascota mascota)
        {
            return _database.InsertAsync(mascota);
        }

        public Task<List<Mascota>> ObtenerMascotasAsync()
        {
            return _database.Table<Mascota>().ToListAsync();
        }

        public Task<int> EliminarMascotaAsync(Mascota mascota)
        {
            return _database.DeleteAsync(mascota);
        }
    }
}
