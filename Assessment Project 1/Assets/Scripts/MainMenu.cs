//THIS SCRIPT IS FROM A TUTORIAL

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Important - This allows the buttons to transfer the user to different scenes
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Press Play Button = Go to Build Scene 1 (Game Scene)
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
