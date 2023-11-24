using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Zombie : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar ZhealthBar;

    //public Rigidbody Zrb;
    public float speed = 5.0f;
    Vector3 movement;
    //Vector3 ImpulseVector = new Vector3(-50.0f,0.0f,0.0f);

    void Start()
    {
		currentHealth = maxHealth;
		ZhealthBar.SetMaxHealth(maxHealth);
        //Zrb = GetComponent<Rigidbody>();
    }

    // void FixedUpdate()
    // {
    //     movement.x = Input.GetAxis("Horizontal");
    //     movement.y = Input.GetAxis("Vertical");

    //     Zrb.MovePosition(Zrb.position + movement * speed * Time.fixedDeltaTime);
    // }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		ZhealthBar.SetHealth(currentHealth);
	}

    void OnCollisionEnter(Collision collideZ)
    {
        if(collideZ.gameObject.name == "Player")
        {
            TakeDamage(2); 
            Debug.Log("Zombie down!!!!!"); 
            //Zrb.AddForce(ImpulseVector,ForceMode.Impulse);
        }    
    }
}