using System;
using System.Collections.Generic;
using UnityEngine;
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
    private Dictionary<ObjectType, ObjectListToPool> pools;
    public List<TypeObjectToPool> objectPrefab;

    private void Awake()
    {
        _singleton = this;
        Initialize();
    }

    internal void Initialize()
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
