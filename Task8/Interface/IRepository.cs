using System.Collections.Generic;

public interface IEntity{
    int Id { get; set; }
}

public interface IRepository<T> where T : class, IEntity{
    void Add(T item);
    List<T> GetAll();
    T GetById(int id);
    void Update(T item);
    void Delete(int id);
}