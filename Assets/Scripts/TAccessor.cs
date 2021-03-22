using System.Collections.Generic;

public class TAccessor <T>
{
    private List<T> _listModules;
    
    public void Add(T obj)
    {
        _listModules.Add(obj);
    }
    
    public void Remove(T obj)
    {
        _listModules.Remove(obj);
    }
}
