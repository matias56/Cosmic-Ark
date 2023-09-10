using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mini : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Vector2 mov;
    public static float cSlain;
    public Transform fp;
    public GameObject ufol;
    public float cdT = 1.2f;
    private float iT = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cSlain = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mov.x = Input.GetAxisRaw("Horizontal");
        mov.y = Input.GetAxisRaw("Vertical");

       


        if (Time.time > iT)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(ufol, fp.position, Quaternion.identity);
                iT = Time.time + cdT;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mov * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ELaser")
        {
            Score.health -= 25;
        }
    }
}
