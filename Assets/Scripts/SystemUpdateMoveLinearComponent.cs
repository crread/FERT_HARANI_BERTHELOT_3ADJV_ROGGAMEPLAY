using Components;using UnityEngine;

public class SystemUpdateMoveLinearComponent : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<LinearDeplacement> accessor = TAccessor<LinearDeplacement>.Instance();
        
        foreach (LinearDeplacement module in accessor.GetAllModules())
        {
            module.gameObject.transform.position += (module.speed * Time.deltaTime) * module.direction;
        }
    }
}
