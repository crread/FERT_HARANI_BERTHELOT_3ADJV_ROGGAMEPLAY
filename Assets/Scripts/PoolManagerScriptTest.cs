using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManagerScriptTest : MonoBehaviour
{
    private List<Entity> _objects;
    
    void Start()
    {
        _objects = new List<Entity>();
        PoolManager poolManager = PoolManager.Instance();

        for (int i = 0; i < 10; ++i)
        {
            Entity obj = poolManager.GetPooledObject(ObjectType.Ennemy);
            if (obj != null)
            {
                obj.Init();
                _objects.Add(obj);
            }
        }

        int objectCount = _objects.Count;
        for (int i = 0; i < objectCount; ++i)
        {
            if (_objects[i] != null)
            {
                poolManager.ReleasePoolObject(_objects[i]);
            }
        }
    }
}
