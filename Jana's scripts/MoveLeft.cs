using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 5.0f;
    public Rigidbody Zrb;

    // Start is called before the first frame update
    void Start()
    {
        //Zrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);  
    }

    void OnCollisionEnter(Collision collideW)
    {
        if(collideW.gameObject.name == "Player")
        {
            //transform.Translate(Vector3.AddForce * Time.deltaTime * speed); 
            Debug.Log("ZGDGKJN"); 
            
        }
    }
 
}
