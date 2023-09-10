using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D rb;
    private float dirY;
    public float cdT = 1.2f;
    private float iT = 0f;
    public Transform sp;
    public GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dirY = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y == 4.7f || transform.position.y == -4.7f)
        {
            dirY *= -1f;
        }

        if (Time.time > iT)
        {
            
                Instantiate(laser, sp.position, sp.rotation);
                iT = Time.time + cdT;
            
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.y, dirY * speed);
    }

   
}
