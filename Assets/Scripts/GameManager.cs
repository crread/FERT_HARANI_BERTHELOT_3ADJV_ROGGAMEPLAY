using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PoolManager _poolmanager;
    private MyUpdater myUpdater;
    private List<GenericComponent> _listTest = new List<GenericComponent>();
    void Start()
    {
        myUpdater = gameObject.AddComponent<MyUpdater>();
        
        for (int i = 0; i < 10; i++)
        {
            _listTest.Add(new MoveHorizontallyComponent());
            _listTest.Add(new MoveVerticallyComponent());
        }

        myUpdater.SystemUpdate(_listTest);
        
        // _poolmanager = gameObject.GetComponent<PoolManager>();
        // _poolmanager.Initialize();
        // GameObject go = _poolmanager.GetPooledObject(ObjectType.Ennemy).gameObject;
        
    }
    
    void Update()
    {
        
    }
}
