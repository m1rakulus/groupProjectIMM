using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZombieAlpha : MonoBehaviour
{

	public int BmaxHealth = 100;
	public int BcurrentHealth;
    public HealthBar BhealthBar;
    public Rigidbody rb;
    //private float Bspeed = 5.0f;
 
    void Start()
    {
		BcurrentHealth = BmaxHealth;
		BhealthBar.SetMaxHealth(BmaxHealth);
    }

    
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * Bspeed);  
		if (Input.GetKeyDown(KeyCode.F))
		{
			TakeDamage(20);
		}

        if(BcurrentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

	void TakeDamage(int damage)
	{
		BcurrentHealth -= damage;

		BhealthBar.SetHealth(BcurrentHealth);
	}

    void OnCollisionEnter(Collision collide)
    {
        if(collide.gameObject.name == "Dog")
        {
            Debug.Log("Zombie hit!");
            //TakeDamage(2);
        }    
    }


}