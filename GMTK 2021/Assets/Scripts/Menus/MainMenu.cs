using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public GameObject[] Buttons;
    public int SelectedButton;

    // Start is called before the first frame update
    void Start()
    {
        SelectedButton = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")) SelectedButton++;
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown("s")) SelectedButton--;
        if (SelectedButton > 3) SelectedButton = 3;
        else if (SelectedButton < 0) SelectedButton = 0;
    }
}
