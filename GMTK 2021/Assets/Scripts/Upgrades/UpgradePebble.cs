using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UpgradePebble : MonoBehaviour
{
    [SerializeField] InformationContainer container;
    [SerializeField] string upgradeType, dialogueID;

    private void Awake() 
    {
        if(container.unlockedUpgrades.Where(i => i.GetType() == System.Type.GetType(upgradeType)).ToArray().Length > 0) { Destroy(gameObject); }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(!other.gameObject.GetComponent<PlayerController>()) { return; }
        var t = System.Type.GetType(upgradeType);
        var u = System.Activator.CreateInstance(t) as Upgrade;
        container.unlockedUpgrades.Add(u);
        u.OnPickup(container);
       StartCoroutine(FindObjectOfType<SpeechSystem>().OpenDialogue(dialogueID,3f));

        if(
            container.unlockedUpgrades.Where(i => i.GetType() == typeof(Metal1)).ToArray().Length > 0 &&
            container.unlockedUpgrades.Where(i => i.GetType() == typeof(Metal2)).ToArray().Length > 0 &&
            container.unlockedUpgrades.Where(i => i.GetType() == typeof(Metal3)).ToArray().Length > 0
        )
        {
            container.endingGame = true;
            Scenemanager.instance.GoToScene(8);
        }

        Destroy(gameObject);
    }
}
