using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar healthBar;
    public Rigidbody rb;
    Vector3 ImpulseVector = new Vector3(-100.0f,0.0f,0.0f);
    //public float speed = 50.0f;

    void Start()
    {
		//Setting the starting health to max health
        currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);

        //startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
		// if (Input.GetKeyDown(KeyCode.Space))
		// {
		// 	TakeDamage(2);
		// }
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

    void OnCollisionEnter(Collision collide)
    {
        if(collide.gameObject.name == "Zombie")
        {
            Debug.Log("Player hit by Zombie");
            TakeDamage(2);
            rb.AddForce(ImpulseVector,ForceMode.Impulse);
            //rb.velocity = Vector3.zero;

        }    
    }

    // void FixedUpdate()
    // {
    //     float x = Input.GetAxisRaw("Horizontal");
    //     float z = Input.GetAxisRaw("Vertical");

    //     rb.position += z * transform.forward * Time.deltaTime * speed;
    //     rb.position += x * transform.right * Time.deltaTime * speed;
    // }
}