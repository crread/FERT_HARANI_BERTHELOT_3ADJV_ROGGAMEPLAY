using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType
{
    Player,
    Ennemy,
    Bullet
}
public class ObjectListToPool
{
    private List<Entity> _objectInPool;

    public void Initialize(Entity parPrefabObject, int parNumber)
    {
        _objectInPool = new List<Entity>();
        for (int i = 0; i < parNumber; ++i)
        {
            Entity newEntityInstance = MonoBehaviour.Instantiate(parPrefabObject);
            newEntityInstance.DeInit();
            _objectInPool.Add(newEntityInstance);
        }
    }

    public Entity PullObject()
    {
        int numberObjectInPool = _objectInPool.Count;
        
        for (int i = 0; i < numberObjectInPool; ++i)
        {
            if (!_objectInPool[i].IsActive())
            {
                return _objectInPool[i];
            }
        }
        
        return null;
    }
}
