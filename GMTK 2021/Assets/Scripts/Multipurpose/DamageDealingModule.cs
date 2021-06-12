using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealingModule : MonoBehaviour
{
    [SerializeField] float _damageDealt;

    private void OnTriggerEnter2D(Collider2D other) {
        

        var hp = other.GetComponent<HealthComponent>();
        if(!hp || other.isTrigger){ return; }

        hp.Health -= _damageDealt;

    }
}
