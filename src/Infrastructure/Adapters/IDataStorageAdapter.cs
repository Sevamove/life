using Infrastructure.Interfaces;

namespace Infrastructure.Adapters;

public interface IDataStorageAdapter<T> : IRepository<T> { }