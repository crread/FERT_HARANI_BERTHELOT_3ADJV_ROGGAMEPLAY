using System;
using System.Collections.Generic;
using UnityEngine;

public class TAccessor :MonoBehaviour
{
    private Dictionary<string, List<GenericComponent>> _dicoUpdater = new Dictionary<string, List<GenericComponent>>();
    private Dictionary<string, IUpdater> _systemUpdater = new Dictionary<string, IUpdater>();
    public static TAccessor Instance() { return _singleton; }
    private static TAccessor _singleton;

    private void Awake()
    {
        _singleton = this;
    }

    public void UpdateSystemUpdate()
    {
        foreach (var dicoData in _dicoUpdater)
        {
            if (_systemUpdater.ContainsKey(dicoData.Key))
            {
                _systemUpdater[dicoData.Key].Test(dicoData.Value);
            }
            else
            {
                Debug.Log($"{dicoData.Key} is not available in system updater list");
            }
        }
    }
    public void AddModules(Component[] genericComponentlist)
    {
        foreach (var component in genericComponentlist)
        {
            if (!_dicoUpdater.ContainsKey(component.GetType().Name))
            {
                _dicoUpdater.Add(component.GetType().Name, new List<GenericComponent>());
                _systemUpdater.Add(component.GetType().Name, (IUpdater) Activator.CreateInstance(Type.GetType($"SystemUpdate{component.GetType().Name}")));
            }
            _dicoUpdater[component.GetType().Name].Add((GenericComponent)component);
        }
    }
}
