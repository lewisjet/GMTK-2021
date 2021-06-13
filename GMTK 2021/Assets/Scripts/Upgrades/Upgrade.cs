using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Upgrade
{
    public virtual void OnPickup(InformationContainer ic){
        ic.hp = ic.hp + 50f > 100f ? 100f : ic.hp + 50f;
    }
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
        base.OnPickup(ic);
    }
}
public class Gun : Upgrade
{
    public override void Invoke(PlayerController pc)
    {
        if(Input.GetButtonDown("Submit"))
        {
           var x = pc.PCInstantiate<DamageDealingModule>(pc.bullet);
           x.gameObject.transform.position = pc.transform.position;
           var xPos = pc.spriteRenderer.transform.localScale.x == Mathf.Abs(pc.transform.localScale.x) ? 1f : -1f;
           x.gameObject.transform.localScale = new Vector3(xPos, 1f , 1f );
        }
    }
}