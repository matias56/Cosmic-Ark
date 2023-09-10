using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Civilian : MonoBehaviour
{

    public float speed = 4;
    public Rigidbody2D rb;
    private float dirX;
    public Vector3 lS;
    public bool fR = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dirX= -1f;
        lS = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x == 8f || transform.position.x == -8f)
        {
            dirX *= -1f;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * speed, transform.position.y);
    }

    private void LateUpdate()
    {
        CheckFace();
    }

    void CheckFace()
    {
        if(dirX>0)
        {
            fR = true;
        }
        else if (dirX<0)
        {
            fR = false;
        }

        if(((fR)&&(lS.x >0)) || ((!fR) && (lS.x <0)))
        {
            lS.x *= -1;
        }

        transform.localScale = lS;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        dirX *= -1f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Score.curScore += 1000;
        Score.score += 1000;
        Mini.cSlain++;
        Destroy(gameObject);
       
    }
}
