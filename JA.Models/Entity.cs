using System;
using System.Data.SqlClient;
using JA.Logging;
using JA.Models.SharedModels;

namespace JA.Models
{
    public class Entity<T> : IObservable<Entity<T>>, IModificationHistory
    {
        public int Id;

       // public Logging sentDate { get; set; }
        public SqlClientLogger Logger = new SqlClientLogger();
        public IDisposable Subscribe(IObserver<Entity<T>> observer)
        {
            throw new NotImplementedException();
        }

        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}