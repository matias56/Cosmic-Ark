using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
        if(other.gameObject.tag=="Laser")
        {
            Destroy(gameObject);
            Score.score += 5;
            Score.curScore += 5;
            Destroy(other.gameObject);
        }
    }
}
