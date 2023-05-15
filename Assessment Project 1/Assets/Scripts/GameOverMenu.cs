//THIS SCRIPT IS FROM A TUTORIAL

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Important - This allows the buttons to transfer the user to different scenes
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    //Press Retry Button = Go to Build Scene 1 (Game Scene)
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

   //Press Menu Button = Go to Build Scene 0 (Main Menu Screen)
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }

}