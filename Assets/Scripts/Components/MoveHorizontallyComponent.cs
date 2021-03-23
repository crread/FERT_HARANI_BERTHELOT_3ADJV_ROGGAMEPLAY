using UnityEngine;

namespace Components
{
    public class MoveHorizontallyComponent : GenericComponent
    {
        public Vector3 direction = Vector3.right;
        public float speed = 1f;
    }
}
