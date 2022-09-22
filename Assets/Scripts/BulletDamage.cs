using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;


public class BulletDamage : MonoBehaviour
{

    public GameObject playerToTakeDamage;



    [SerializeField]
    float maxHP = 100;


    // public float currentHp = 100;

    [SerializeField]
    int projectileDamage = 10;

    float damageTaken;


    // Start is called before the first frame update
    void Start()
    {
        // maxHP = 100;
        // currentHp = maxHP;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {



        if (collision.gameObject.name == "Player1")
        {
            Hit();
        }

        if (collision.gameObject.name == "Player2")
        {
            Hit2();
        }




        void Hit()
        {
            if (Gamemanager.Instance.currentHpPlayer1 >= 0)
            {

                Gamemanager.Instance.timesHitp1++;
                damageTaken = projectileDamage * Gamemanager.Instance.timesHitp1;
                Gamemanager.Instance.currentHpPlayer1 = maxHP - damageTaken;
               
                
              //  Debug.Log(Gamemanager.Instance.currentHpPlayer1);

                if (Gamemanager.Instance.currentHpPlayer1 < 0)
                {
                    Debug.Log("Player1 has died");
                }
             
            }
        }
        void Hit2()
        {
            if (Gamemanager.Instance.currentHpPlayer2 >= 0)
            {

                Gamemanager.Instance.timesHitp2++;
                damageTaken = projectileDamage * Gamemanager.Instance.timesHitp2;
                Gamemanager.Instance.currentHpPlayer2 = maxHP - damageTaken;

             
            }
            if (Gamemanager.Instance.currentHpPlayer2 < 0)
            {
                Debug.Log("Player2 has died");
            }
        }







       
        
    }
    }
