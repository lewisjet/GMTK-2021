using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePebble : MonoBehaviour
{
    [SerializeField] InformationContainer container;
    [SerializeField] string upgradeType, dialogueID;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        var t = System.Type.GetType(upgradeType);
        var u = System.Activator.CreateInstance(t) as Upgrade;
        container.unlockedUpgrades.Add(u);
        u.OnPickup(container);
       StartCoroutine(FindObjectOfType<SpeechSystem>().OpenDialogue(dialogueID,3f));
        Destroy(gameObject);
    }
}
