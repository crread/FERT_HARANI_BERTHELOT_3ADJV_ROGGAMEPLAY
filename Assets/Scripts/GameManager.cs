using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PoolManager _poolmanager;
    private List<IUpdater> _listTest = new List<IUpdater>();
    public Transform ammoDrop;
    public Vector3 position;
    public GameObject playerp;

    private void Start()
    {
        _poolmanager = gameObject.GetComponent<PoolManager>();
        _poolmanager.Initialize();
        
        _listTest.Add(new SystemUpdateMoveLinearComponent());
       
        
        Entity entity = _poolmanager.GetPooledObject(ObjectType.Ennemy);
        entity.Init();
        Entity entityp = _poolmanager.GetPooledObject(ObjectType.Player);
        entityp.Init();
        entityp.gameObject.transform.position = playerp.transform.position;
    }
    
     IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(1f,4f));
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
            if (entity)
            {
                entity.Init();
            }
 
            position = new Vector3(UnityEngine.Random.Range(-25.0F, 25.0F), 0, UnityEngine.Random.Range(4.0F, 10.0F));
            entity.gameObject.transform.position = position;

        }
        
        
    }
}
