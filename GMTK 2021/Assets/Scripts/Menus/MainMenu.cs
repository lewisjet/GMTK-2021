using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject[] Buttons;
    public Vector2[] ButtonPos;
    public GameObject ButtonCursor;
    public int SelectedButton;

    // Start is called before the first frame update
    void Start()
    {
        SelectedButton = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown("s")) SelectedButton++;
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")) SelectedButton--;
        if (SelectedButton > 3) SelectedButton = 3;
        else if (SelectedButton < 0) SelectedButton = 0;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (SelectedButton == 0) SceneManager.LoadScene(3);
            else if (SelectedButton == 1) SceneManager.LoadScene(1);
            else if (SelectedButton == 2) SceneManager.LoadScene(2);
            else if (SelectedButton == 3) Application.Quit();
        }

        ButtonCursor.transform.position = ButtonPos[SelectedButton];
    }
}
