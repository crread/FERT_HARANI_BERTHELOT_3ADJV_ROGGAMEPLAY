using System.Collections;
using System.Collections.Generic;

public class TAccessor <T>
{
    public List<T> _listModules;
    
    public TAccessor()
    {
        _listModules = new List<T>();
    }
    public void Add(T obj)
    {
        _listModules.Add(obj);
    }
    
    public void Remove(T obj)
    {
        _listModules.Remove(obj);
    }
}
