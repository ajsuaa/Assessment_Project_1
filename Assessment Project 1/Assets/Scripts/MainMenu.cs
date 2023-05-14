//Ths Script is from a tutorial
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Important
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Load Scene = Start playing game
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
