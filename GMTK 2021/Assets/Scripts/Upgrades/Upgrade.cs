using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Upgrade
{
    public virtual void OnPickup(InformationContainer ic){}
    public virtual void Invoke(){}
}


public class Metal1 : Upgrade {}
public class Metal2 : Upgrade {}
public class Metal3 : Upgrade {}
public class HighJump : Upgrade 
{
    public override void OnPickup(InformationContainer ic)
    {
        ic.jumpHeight += 5f;
    }
}