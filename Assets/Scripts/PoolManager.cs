using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance() { return _singleton; }
    private static PoolManager _singleton;
    public List<TypeObjectToPool> ObjectPrefab;
    public Dictionary<ObjectType, ObjectListToPool> pools;

    private void Awake()
    {
        _singleton = this;
        Initialize();
    }

    private void Initialize()
    {
        pools = new Dictionary<ObjectType, ObjectListToPool>();
        foreach (TypeObjectToPool obj in ObjectPrefab)
        {
            ObjectListToPool newObjectListToPool = new ObjectListToPool();
            newObjectListToPool.Initialize(obj.prefab, obj.Number);
            pools.Add(obj.ObjectType, newObjectListToPool);
        }
    }

    public Entity GetPooledObject(ObjectType parObjectType)
    {
        return pools[parObjectType].PullObject();
    }

    public void ReleasePoolObject(Entity parObject)
    {
        parObject.DeInit();
    }
}
