using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class turnManager : MonoBehaviour
{



    public GameObject Camera;
    public GameObject Player;
    public GameObject playerTurn;



    void Update()
    {
        if (Camera.GetComponent<Camera>().enabled)
        {

            Player.GetComponent<movementPlayer>().enabled = true;
            Player.GetComponent<cameraMovement>().enabled = true;
            Player.GetComponent<Gun>().enabled = true;
            playerTurn.SetActive(true);
        }
        if (!Camera.GetComponent<Camera>().enabled)
        {

            Player.GetComponent<movementPlayer>().enabled = false;
            Player.GetComponent<cameraMovement>().enabled = false;
            Player.GetComponent<Gun>().enabled = false;

            playerTurn.SetActive(false);

        }



    }
}
