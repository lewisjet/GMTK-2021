using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{

    [SerializeField] private float _health;
    [SerializeField] private InformationContainer _info;
    [SerializeField] private bool _isNotHuman;
    

    [Tooltip("Leave at 0 for no maximum")]
    [SerializeField] private float _maxHealth;
    public float Health { get { return _health; }
     set
     {
         _health = value;
         if(_health > _maxHealth && _maxHealth != 0) { _health = _maxHealth; }
         if(!_isNotHuman) _info.hp = _health;
         if(_health <= 0){ Destroy(gameObject); }

     }}

     private void Awake() 
     {
         if(!_isNotHuman)
         _health = _info.hp;
     }

}