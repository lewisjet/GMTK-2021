using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DamageDealingModule : MonoBehaviour
{
    [SerializeField] float _damageDealt;
    [SerializeField] bool _destroyOnImpact;
    [SerializeField] int[] _notableCeasefires;
    [SerializeField] int _CeasefireID;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        

        var hp = other.gameObject.GetComponentInChildren<HealthComponent>();
        if(!hp)
        { 
             hp = other.gameObject.GetComponent<HealthComponent>();
             if(!hp)
             {return;} 
        }
        var x = other.gameObject.GetComponent<DamageDealingModule>();
        if(x && _notableCeasefires.Contains(x._CeasefireID))
        {
            return;
        }

        hp.Health = hp.Health - _damageDealt;

        if(_destroyOnImpact){ Destroy(gameObject); }

    }
}
