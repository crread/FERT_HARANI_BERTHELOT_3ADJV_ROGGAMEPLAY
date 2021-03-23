using System.Collections;
using UnityEngine;

public class TAccessor<T>
{
    private static TAccessor<T> _singleton;
    public static TAccessor<T> Instance()
    {
        if (_singleton == null)
        {
            _singleton = new TAccessor<T>();
        }
        return _singleton;
    }
    public TAccessor() {}

    public IEnumerable GetAllModules() => Object.FindObjectsOfType(typeof(T));
}
