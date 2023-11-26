using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject[] dogPrefab;
    private float spawnLimitXRight = 59;
    private float spawnLimitXAgain = 59;
    private float spawnPosY = 0; 

    // public int maxHealth = 100;
	// public int currentHealth;
	// public HealthBar AhealthBar;
    // public Rigidbody rb;

    // void Start()
    // {
	// 	currentHealth = maxHealth;
	// 	AhealthBar.SetMaxHealth(maxHealth);
    // }

    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0,dogPrefab.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXRight,spawnLimitXAgain), spawnPosY, -29);
            Instantiate(dogPrefab[index], transform.position, dogPrefab[index].transform.rotation);
            // TakeDamage(20);
        }
    }
}
