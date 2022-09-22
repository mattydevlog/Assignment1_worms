using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Randomspawner : MonoBehaviour
{
    public GameObject[] mySpawns;

    public GameObject[] spawnPoints;

    int index = 0;


    void Start()
    {
        for (int i = 0; i < mySpawns.Length; i++)
        {
            int randomIndex = Random.Range(0, mySpawns.Length);
            Instantiate(mySpawns[randomIndex], spawnPoints[index].transform.position, Quaternion.identity);
            index++;
            index %= spawnPoints.Length;

        }
    }


}
