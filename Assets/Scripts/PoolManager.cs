using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public struct TypeObjectToPool
{
    public ObjectType objectType;
    public Entity prefab;
    public int number;
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
            newObjectListToPool.Initialize(obj.prefab, obj.number);
            pools.Add(obj.objectType, newObjectListToPool);
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
