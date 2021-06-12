using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePebble : MonoBehaviour
{
    [SerializeField] InformationContainer container;
    [SerializeField] string upgradeType;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        var t = System.Type.GetType(upgradeType);
        var u = System.Activator.CreateInstance(t) as Upgrade;
        container.unlockedUpgrades.Add(u);
        u.OnPickup(container);
        Destroy(gameObject);
    }
}

