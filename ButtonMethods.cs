using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

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
