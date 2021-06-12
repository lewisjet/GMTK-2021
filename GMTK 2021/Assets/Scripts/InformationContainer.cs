using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class InformationContainer : ScriptableObject
{
    public float hp = 100f;
    public List<Upgrade> unlockedUpgrades;

    public int doorId = -1;

}
