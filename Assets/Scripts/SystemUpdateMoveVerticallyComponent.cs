using Components;using UnityEngine;

public class SystemUpdateMoveVerticallyComponent : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<MoveVerticallyComponent> accessor = TAccessor<MoveVerticallyComponent>.Instance();
        
        foreach (MoveVerticallyComponent module in accessor.GetAllModules())
        {
            module.gameObject.transform.position += (module.speed * Time.deltaTime) * module.direction;
        }
    }
}
