using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Transform[] sp = new Transform[4];
    public Laser[] laser;

    public float cdT = 1f;
    private float iT = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > iT)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Instantiate(laser[0], sp[0].position, sp[0].rotation);
                iT = Time.time + cdT;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Instantiate(laser[1], sp[1].position, sp[1].rotation);
                iT = Time.time + cdT;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Instantiate(laser[2], sp[2].position, sp[2].rotation);
                iT = Time.time + cdT;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Instantiate(laser[3], sp[3].position, sp[3].rotation);
                iT = Time.time + cdT;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Asteroid")
        {
            Score.health -= 5;
        }
    }
}
