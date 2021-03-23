using System.Collections.Generic;
using UnityEngine;

public class SystemUpdateMoveHorizontallyComponent : MonoBehaviour, IUpdater
{
    public void Test(List<GenericComponent> modules)
    {
        foreach (GenericComponent module in modules)
        {
            Debug.Log(module);
            // module.gameObject.transform.position = module.direction * module.speed;
        }
    }
}