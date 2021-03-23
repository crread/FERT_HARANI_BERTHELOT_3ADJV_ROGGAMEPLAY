using System.Collections.Generic;
using UnityEngine;

public class SystemUpdate : MonoBehaviour, IUpdater
{
    public void Test(List<GenericComponent> modules)
    {
        Debug.Log("test");
    }
}
