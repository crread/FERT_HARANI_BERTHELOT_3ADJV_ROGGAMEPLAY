using UnityEngine;

namespace Components
{
    public class LinearDeplacement : GenericComponent
    {
        //Module HMov
        public float speed = 1f;
        public Vector3 direction = new Vector3(0, 1, 0);
    }
}