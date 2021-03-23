// using System.Collections.Generic;
// using UnityEngine;
//
// public class MyUpdater : MonoBehaviour
// {
//     private Dictionary<string, TAccessor<GenericComponent>> _dicoUpdater = new Dictionary<string, TAccessor<GenericComponent>>();
//     public static MyUpdater Instance() { return _singleton; }
//     private static MyUpdater _singleton;
//
//     private void Awake()
//     {
//         _singleton = this;
//     }
//     public void SystemUpdate(List<GenericComponent> genericComponentlist)
//     {
//         foreach (var component in genericComponentlist)
//         {
//             if (!_dicoUpdater.ContainsKey(component.GetType().Name))
//             {
//                 _dicoUpdater.Add(component.GetType().Name, new TAccessor<GenericComponent>());
//             }
//             _dicoUpdater[component.GetType().Name].Add(component);
//         }
//     }
// }
