using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearer : MonoBehaviour
{
    [SerializeField] InformationContainer container;
    private void Awake() 
    {
        if(FindObjectsOfType<Clearer>().Length > 1){ Destroy(gameObject); return; }
        DontDestroyOnLoad(this.gameObject);

        container.Clear();
    }
}
