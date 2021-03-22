using UnityEngine;

public class GenericComponent : MonoBehaviour
{ //Module
    public virtual void Move(Vector3 direction) {}

    public int GetInstanceID()
    {
        return gameObject.GetInstanceID();
    }
    
}
