using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Components;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 position;
    public Camera camera;
    private PoolManager _poolmanager;
    private List<IUpdater> _listTest = new List<IUpdater>();
    private GameObject _player;
    private List<Entity> objects = new List<Entity>();
    private void Start()
    {
        _poolmanager = PoolManager.Instance();

        _listTest.Add(new SystemUpdateMoveLinearComponent());
        
        Entity playerEntity = _poolmanager.GetPooledObject(ObjectType.Player);
        _player = playerEntity.gameObject;
        playerEntity.Init();
        objects.Add(playerEntity);
    }

    private void Update()
    {
        foreach (var system in _listTest)
        {
            system.SystemUpdate();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Entity bullet = _poolmanager.GetPooledObject(ObjectType.Bullet);
            var gameObject = bullet.gameObject;
            gameObject.transform.rotation = _player.transform.rotation;
            gameObject.transform.position = _player.transform.position;
            bullet.Init();
            objects.Add(bullet);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Entity entity = _poolmanager.GetPooledObject(ObjectType.Ennemy);
            if (entity)
            {
                entity.Init();
            }
            else
            {
                Debug.Log("no more ennemy available");
            }
 
            position = new Vector3(Random.Range(-25.0F, 25.0F), 0, Random.Range(4.0F, 10.0F));
            entity.gameObject.transform.position = position;
        }
    }
}
