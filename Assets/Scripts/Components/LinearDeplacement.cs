using UnityEngine;

namespace Components
{
    public class LinearDeplacement : GenericComponent
    {
        //Module HMov
        public float speed = 1f;
        public Vector3 forward = Vector3.forward;
        public Vector3 back = Vector3.back;
        public Vector3 right = Vector3.right;
        public Vector3 left = Vector3.left;
    }
}