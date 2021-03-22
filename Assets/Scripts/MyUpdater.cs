using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MyUpdater : MonoBehaviour
{
    private Dictionary<String, TAccessor<GenericComponent>> _dicoUpdater;

    public void SystemUpdate(List<GenericComponent> genericComponentlist)
    {
        for (int i = 0; i < genericComponentlist.Count; i++)
        {
            if (_dicoUpdater == null)
            {
                _dicoUpdater = new Dictionary<genericComponentlist[i].GetType().name(), TAccessor<genericComponentlist[i].GetType().name()>>;
            }
            
            
            if (_dicoUpdater[genericComponentlist[i].GetType().name()] == null)
            {
                _dicoUpdater[genericComponentlist[i].GetType().name()] = new TAccessor<randomList[i].GetType.name()>;
            }
        }
       

      
      
    }

}
