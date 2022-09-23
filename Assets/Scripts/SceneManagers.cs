using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagers : MonoBehaviour
{


    // Update is called once per frame
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void EndGame()
    {
        Application.Quit();
       
    }
}
