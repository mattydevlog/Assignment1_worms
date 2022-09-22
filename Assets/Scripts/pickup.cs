using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject healthPack;
    float healthValue = 15;



    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player1")
        {
            if (Gamemanager.Instance.currentHpPlayer1 != 100)
            {
                Gamemanager.Instance.currentHpPlayer1 = Gamemanager.Instance.currentHpPlayer1 + healthValue;

                Destroy(healthPack);
            }
        }

        if (collision.gameObject.name == "Player2")
        {
            if (Gamemanager.Instance.currentHpPlayer1 != 100)
            {
                Gamemanager.Instance.currentHpPlayer2 = Gamemanager.Instance.currentHpPlayer2 + healthValue;


                Destroy(healthPack);
            }
        }
    }
}