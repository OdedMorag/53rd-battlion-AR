using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public void GoNextScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void QuitPlay()
    {
        Application.Quit();
    }
}
