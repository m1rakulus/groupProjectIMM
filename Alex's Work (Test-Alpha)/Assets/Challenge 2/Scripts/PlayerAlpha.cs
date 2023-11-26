using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerAlpha : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar AhealthBar;
    public Rigidbody rb;

 
    void Start()
    {
		currentHealth = maxHealth;
		AhealthBar.SetMaxHealth(maxHealth);
    }

    
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.D))
		{
			TakeDamage(20);
		}

        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collide)
    {
        Debug.Log("Player hit by Zombie");
        if(collide.gameObject.name == "BasicMotionsDummy")
        {
            Debug.Log("Player hit by Zombie");
            TakeDamage(20);
        }    
    }

    void TakeDamage(int damage)
	{
		currentHealth -= damage;

		AhealthBar.SetHealth(currentHealth);
	}


}