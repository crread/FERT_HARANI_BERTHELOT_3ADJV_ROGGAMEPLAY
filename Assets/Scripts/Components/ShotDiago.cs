using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDiago : GenericComponent
{      //Module ShotDiagonal
        //vector.x = vector.x*sensx , vector.y = vector.y * sensy
        //vitesse * vector3
        
        private int sensx = 1;
        private int sensy = 1;
        private int vitesse = 1;
        Vector3 vector = new Vector3(0,1,0);
        private int Dammage = 1;

        public int getsensx()
        {
                return sensx;
        }
    
        public int getsensy()
        {
                return sensy;
        }
    
        public int getvitesse()
        {
                return vitesse;
        }
    
        public Vector3 getvector()
        {
                return vector;
        }

        public int getdammage()
        {
                return Dammage;
        }

    
}
