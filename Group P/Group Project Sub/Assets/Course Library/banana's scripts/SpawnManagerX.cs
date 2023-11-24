using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -53.1f;
    private float spawnLimitXRight = -53.1f;
    private float spawnPosY = 0;
    //private float spawnPosZ = -29;
    //private float spawnPosX = -53.1f;

    private float startDelay = 1.0f;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int index = Random.Range(0,ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, -29);

        // instantiate ball at random spawn location
        //Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
        //Instantiate(ballPrefabs, transform.position, ballPrefabs.transform.rotation);
    }

}
