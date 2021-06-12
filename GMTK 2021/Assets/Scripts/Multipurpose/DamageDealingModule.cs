using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealingModule : MonoBehaviour
{
    [SerializeField] float _damageDealt;
    [SerializeField] bool _destroyOnImpact;
    private void OnCollisionEnter2D(Collision2D other) {
        

        var hp = other.gameObject.GetComponent<HealthComponent>();
        if(!hp){ return; }

        hp.Health = hp.Health - _damageDealt;

        if(_destroyOnImpact){ Destroy(gameObject); }

    }
}
