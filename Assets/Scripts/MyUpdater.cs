using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MyUpdater : MonoBehaviour
{
    private Dictionary<string, TAccessor<GenericComponent>> _dicoUpdater = new Dictionary<string, TAccessor<GenericComponent>>();

    public static MyUpdater Instance() { return _singleton; }
    private static MyUpdater _singleton;

    private void Awake()
    {
        _singleton = this;
    }
    public void SystemUpdate(List<GenericComponent> genericComponentlist)
    {
        for (int i = 0; i < genericComponentlist.Count; i++)
        {
            if (!_dicoUpdater.ContainsKey(genericComponentlist[i].GetType().Name))
            {
                
                _dicoUpdater[genericComponentlist[i].GetType().Name] = new TAccessor<genericComponentlist[i].GetType()>();
            }
        }
    }
}
