using UnityEngine;

namespace Components
{
    public class MoveVerticallyComponent : GenericComponent
    {
        public Vector3 direction = Vector3.forward;
        public float speed = 1f;
    }
}
