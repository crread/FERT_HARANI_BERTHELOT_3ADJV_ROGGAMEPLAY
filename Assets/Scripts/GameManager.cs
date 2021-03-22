using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PoolManager _poolmanager;
    void Start()
    {
        _poolmanager = gameObject.GetComponent<PoolManager>();
        _poolmanager.Initialize();
        GameObject go = _poolmanager.GetPooledObject(ObjectType.Ennemy).gameObject;
        
    }
    
    void Update()
    {
        
    }
}
