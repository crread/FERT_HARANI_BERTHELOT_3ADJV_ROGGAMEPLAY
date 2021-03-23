using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PoolManager _poolmanager;
    private List<IUpdater> _listTest = new List<IUpdater>();

    private void Start()
    {
        _poolmanager = gameObject.GetComponent<PoolManager>();
        _poolmanager.Initialize();
        
        _listTest.Add(new SystemUpdateMoveHorizontallyComponent());
        _listTest.Add(new SystemUpdateMoveVerticallyComponent());
        
        Entity entity = _poolmanager.GetPooledObject(ObjectType.Ennemy);
        entity.Init();

    }
    
    private void Update()
    {
        foreach (var system in _listTest)
        {
            system.SystemUpdate();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Entity entity = _poolmanager.GetPooledObject(ObjectType.Ennemy);
            entity.Init();
        }
    }
}
