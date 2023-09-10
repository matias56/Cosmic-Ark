using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 50;
    public static bool isR;
    public static bool isU;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.position += transform.right * speed * Time.deltaTime;
        
      
        if(transform.position.x == 7f || transform.position.x == -7f)
        {
            Destroy(this.gameObject);
        }
       

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ELaser")
        {
            Destroy(gameObject);
        }
    }
}
