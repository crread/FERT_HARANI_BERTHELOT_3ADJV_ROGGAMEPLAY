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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PoolManager poolManager = PoolManager.Instance();
            foreach (Entity obj in _objects)
            {
                poolManager.ReleasePoolObject(obj);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            PoolManager poolManager = PoolManager.Instance();
            Entity obj = poolManager.GetPooledObject(ObjectType.Ennemy);
            _objects.Add(obj);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            PoolManager poolManager = PoolManager.Instance();
            Entity obj = poolManager.GetPooledObject(ObjectType.Bullet);
            _objects.Add(obj);
        }
    }
}
