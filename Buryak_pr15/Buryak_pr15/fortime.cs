using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buryak_pr15
{
    class fortime
    {
        readonly SQLiteAsyncConnection database;

        public fortime(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<time>().Wait();
        }

        public Task<List<time>> GetTimesAsync()
        {
            //Get all notes.
            return database.Table<time>().ToListAsync();
        }

        public Task<time> GetTimeAsync(int id)
        {
            // Get a specific note.
            return database.Table<time>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveTimeAsync(time note)
        {
            if (note.Id != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(note);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(note);
            }
        }

        public Task<int> DeleteTimeAsync(time note)
        {
            // Delete a note.
            return database.DeleteAsync(note);
        }
    }
}
