using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    public GameObject zombiePrefab;
    private Vector3 spawnPos = new Vector3(-8,0,0);
    private float startDelay = 2;
    private float repeatRate = 2;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnZombie", startDelay, repeatRate);
        //Zrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnZombie()
    {
        Instantiate(zombiePrefab, spawnPos, zombiePrefab.transform.rotation);
        
    }

    // void OnCollisionEnter(Collision collide)
    // {
    //     if(collide.gameObject.name == "Player")
    //     {
    //         //Debug.Log("Player hit by Zombie");
    //         TakeDamage(2);
    //         Zrb.AddForce(ImpulseVector,ForceMode.Impulse);
    //         //rb.velocity = Vector3.zero;

    //     }    
    // }
}
