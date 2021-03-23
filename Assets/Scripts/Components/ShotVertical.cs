using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotVertical : GenericComponent
{ //Module ShotVertical
  //vitesse*vector 
    //if vitesse négative, shot vers le haut
   
    private int vitesse = 1;
    Vector3 vector = new Vector3(0,1,0);
    private int Dammage = 1; 

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
