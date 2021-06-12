using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Upgrade
{
    public virtual void OnPickup(InformationContainer ic){}
    public virtual void Invoke(PlayerController pc){}
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
public class Gun : Upgrade
{
    public override void Invoke(PlayerController pc)
    {
        if(Input.GetButtonDown("Submit"))
        {
           var x = pc.PCInstantiate<DamageDealingModule>(pc.bullet);
           x.transform.position = pc.transform.position;
           x.transform.localScale = pc.transform.localScale;
        }
    }
}