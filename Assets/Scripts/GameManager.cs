using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PoolManager _poolmanager;
    private TAccessor _taccessor;

    private void Start()
    {
        _taccessor = gameObject.GetComponent<TAccessor>();

        _poolmanager = gameObject.GetComponent<PoolManager>();
        _poolmanager.Initialize();
        
        Entity entity = _poolmanager.GetPooledObject(ObjectType.Ennemy);
        Component[] modules = entity.GetComponents(typeof(GenericComponent));

        if (modules.Length > 0)
        {
            _taccessor.AddModules(modules);
            entity.Init();
        }
    }
    
    private void Update()
    {
        _taccessor.UpdateSystemUpdate();
    }
}
