using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance;


    [SerializeField] public movementPlayer playerOne;
    [SerializeField] public movementPlayer playerTwo;
    [SerializeField] public float turnTimer;
    [SerializeField] public float timesHitp1;
    [SerializeField] public float timesHitp2;
    [SerializeField] public float currentHpPlayer1 = 100;
    [SerializeField] public float currentHpPlayer2 = 100;

    public bool isActive;

    


    public TMP_Text HP;
    public TMP_Text HP2;
    public TMP_Text Timer;




    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
           


        }
    }
    private void Update()
    {
        Timer.text = Gamemanager.Instance.turnTimer.ToString("0");
        HP.text = Gamemanager.Instance.currentHpPlayer1.ToString("0");
        HP2.text = Gamemanager.Instance.currentHpPlayer2.ToString("0");



    }


}




