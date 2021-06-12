using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    [SerializeField] private InformationContainer _informationContainer;

    public static Scenemanager instance;
    private void Awake() 
    {
        instance = this;  
    }

    private void Start() 
    {
        if(_informationContainer.doorId == -1) { return; }  
        FindObjectOfType<PlayerController>().transform.position = FindObjectsOfType<Door>().First(i => i.id == _informationContainer.doorId).transform.position;
        _informationContainer.doorId = -1;
    }
    public void GoToScene(int id) => SceneManager.LoadScene(id);
    public void GoToScene(int id, int doorID)
    {
        _informationContainer.doorId = doorID;
        GoToScene(id); 
    }
}
