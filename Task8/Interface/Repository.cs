using System.Collections.Generic;
using System.Linq;

public class Repository<T> : IRepository<T> where T : class, IEntity{
    private List<T> items = new List<T>();

    public void Add(T item){
        items.Add(item);
    }

    public List<T> GetAll(){
        return items;
    }

    public T GetById(int id){
        return items.FirstOrDefault(x => x.Id == id);
    }

    public void Update(T item){
        var oldItem = GetById(item.Id);
        if (oldItem != null){
            items.Remove(oldItem);
            items.Add(item);
        }
    }

    public void Delete(int id){
        var item = GetById(id);
        if (item != null){
            items.Remove(item);
        }
    }
}