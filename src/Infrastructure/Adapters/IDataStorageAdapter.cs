using Infrastructure.Entities;
using Infrastructure.Repositories;

namespace Infrastructure.Adapters;

public interface IDataStorageAdapter<T> : IRepository<T> { }