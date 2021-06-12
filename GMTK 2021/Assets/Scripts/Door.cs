using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int id;
    public int targetID;
    public int targetSceneID;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        var player = other.GetComponent<PlayerController>();    
        if(player == null){ return; }

        Scenemanager.instance.GoToScene(targetSceneID,targetID);
    }
}
