using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // function must be called by us, not automatically in unity

    public void LoadTargetScene(string sceneToLoad)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToLoad); //loads the scene
    }
}
