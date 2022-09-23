using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using UnityEngine.EventSystems;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance;


    public movementPlayer playerOne;
    public movementPlayer playerTwo;
    public float turnTimer;
    public float timesHitp1;
    public float timesHitp2;
    public float currentHpPlayer1 = 100;
    public float currentHpPlayer2 = 100;

    public bool isActive;





    public TMP_Text HP;
    public TMP_Text HP2;
    public TMP_Text Timer;
    public GameObject player1won;
    public GameObject player2won;
    public GameObject resetSceneButton;
    public GameObject endSceneButton;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Time.timeScale = 1;


        }
    }
    private void Update()
    {
        Timer.text = Gamemanager.Instance.turnTimer.ToString("0");
        HP.text = Gamemanager.Instance.currentHpPlayer1.ToString("0");
        HP2.text = Gamemanager.Instance.currentHpPlayer2.ToString("0");


        if (currentHpPlayer1 <= 0)
        {
            player2won.SetActive(true);
            Time.timeScale = 0;
            resetSceneButton.SetActive(true);
            endSceneButton.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        if (currentHpPlayer2 <= 0)
        {
            player1won.SetActive(true);
            Time.timeScale = 0;
            resetSceneButton.SetActive(true);
            endSceneButton.SetActive(true);
            Cursor.lockState = CursorLockMode.None;

        }

       

    }
}







