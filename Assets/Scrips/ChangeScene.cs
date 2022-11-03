using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("MainScreen");
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("a");
    }
}
