using Components;
using UnityEngine;

public class SystemUpdateMoveHorizontallyComponent : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<MoveHorizontallyComponent> accessor = TAccessor<MoveHorizontallyComponent>.Instance();
        
        foreach (MoveHorizontallyComponent module in accessor.GetAllModules())
        {
            module.gameObject.transform.position += (module.speed * Time.deltaTime) * module.direction;
        }
    }
}