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
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}

        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		AhealthBar.SetHealth(currentHealth);
	}

    void OnCollisionEnter(Collision collide)
    {
        if(collide.gameObject.name == "Zombie")
        {
            Debug.Log("Player hit by Zombie");
            //TakeDamage(2);
        }    
    }


}