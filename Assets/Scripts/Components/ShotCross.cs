using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoCross : GenericComponent
{ //Module ShotVertical 
    
    //Dans le Game manager first : while (distance pas parouru){vitess * vector}
    //Second : isexplose = true Pool 2 shot vertical v = -1 et v=1 et shot horizontal avec v=-1 et v=1
    private int vitesse = 1;
    private int distance = 1;
    private Boolean isexplose = false;
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
