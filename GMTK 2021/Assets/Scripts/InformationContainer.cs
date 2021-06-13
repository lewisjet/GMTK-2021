using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class InformationContainer : ScriptableObject
{
    public float hp = 100f;
    public float jumpHeight = 10.5f;
    public List<Upgrade> unlockedUpgrades = new List<Upgrade>();

    public bool startingGame = true;
    public bool endingGame = false;

    public int doorId = -1;

    public void Clear()
    {
        hp = 100f;
        jumpHeight = 10.5f;
        unlockedUpgrades = new List<Upgrade>();
        doorId = -1;
        startingGame = false;
        endingGame = true;
    }

}
