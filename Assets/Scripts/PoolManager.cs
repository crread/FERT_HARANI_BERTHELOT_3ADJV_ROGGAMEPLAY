using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct TypeObjectToPool
{
    public ObjectType ObjectType;
    public Entity Prefab;
    public int Number;
}

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance() { return _singleton; }
    private static PoolManager _singleton;
    public List<TypeObjectToPool> objectPrefab;
    public Dictionary<ObjectType, ObjectListToPool> pools;

    private void Awake()
    {
        _singleton = this;
        Initialize();
    }

    private void Initialize()
    {
        pools = new Dictionary<ObjectType, ObjectListToPool>();
        foreach (TypeObjectToPool obj in objectPrefab)
        {
            ObjectListToPool newObjectListToPool = new ObjectListToPool();
            newObjectListToPool.Initialize(obj.Prefab, obj.Number);
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
