using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator anim;
    [SerializeField] private InformationContainer container;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

       if(container.startingGame) { anim.SetTrigger("start"); }
       if(container.endingGame) { anim.SetTrigger("end"); }
    }

    public void EndAnims()
    {
        container.startingGame = false;
        container.endingGame = false;
    }

    public void DialogueOpen(string id) => FindObjectOfType<SpeechSystem>().OpenDialogue(id);
    public void DialogueClose() => FindObjectOfType<SpeechSystem>().CloseDialogue();
    public void GameEnd() => Scenemanager.instance.GoToScene(7);
    public void FreePlayer() => FindObjectOfType<PlayerController>().transform.parent = this.transform;
}
