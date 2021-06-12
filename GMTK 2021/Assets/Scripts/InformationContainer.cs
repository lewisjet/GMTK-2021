using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class InformationContainer : ScriptableObject
{
    public float hp = 100f;
    public float jumpHeight = 10.5f;
    public List<Upgrade> unlockedUpgrades = new List<Upgrade>();

    public int doorId = -1;

}
