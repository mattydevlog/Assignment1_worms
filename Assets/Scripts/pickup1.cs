using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup1 : MonoBehaviour
{
    public GameObject timepack;
    float timeValue = 5;



    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            if (Gamemanager.Instance.turnTimer != 0)
            {
                Gamemanager.Instance.turnTimer = Gamemanager.Instance.turnTimer + timeValue;

                Destroy(timepack);
            }
        }

    }
}