using Components;using UnityEngine;

public class SystemUpdateMoveLinearComponent : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<LinearDeplacement> accessor = TAccessor<LinearDeplacement>.Instance();
        
        foreach (LinearDeplacement module in accessor.GetAllModules())
        {
            if (module.gameObject.CompareTag("Player"))
            {
                PlayerMouvements(module);
            }
            else
            {
                module.gameObject.transform.Translate(module.speed * Time.deltaTime * module.left);
                module.gameObject.transform.Translate(module.speed * Time.deltaTime * module.right);
                module.gameObject.transform.Translate(module.speed * Time.deltaTime * module.forward);
                module.gameObject.transform.Translate(module.speed * Time.deltaTime * module.back);
            }
        }
    }

    private void PlayerMouvements(LinearDeplacement module)
    {
        Plane playerPlane = new Plane(Vector3.up, module.gameObject.transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        if (playerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - module.gameObject.transform.position);
            targetRotation.x = 0;
            targetRotation.z = 0;
            module.gameObject.transform.rotation=Quaternion.Slerp(module.gameObject.transform.rotation, targetRotation, 7f * Time.deltaTime);
        }
                
        if (Input.GetKey(KeyCode.Q))
        {
            module.gameObject.transform.Translate(module.speed * Time.deltaTime * module.left);        
        }
        if (Input.GetKey(KeyCode.D))
        {
            module.gameObject.transform.Translate(module.speed * Time.deltaTime * module.right);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            module.gameObject.transform.Translate(module.speed * Time.deltaTime * module.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            module.gameObject.transform.Translate(module.speed * Time.deltaTime * module.back);
        }
    }
}
