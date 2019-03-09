using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
//this is where I create all methods for the buttons in my game. 
public class ButtonMethods : MonoBehaviour
{
    public void quit()
    {
        Application.Quit(); 
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene("MainScene"); 
    }
}
