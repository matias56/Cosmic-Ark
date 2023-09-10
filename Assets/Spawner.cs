using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float[] cdTime;
    private float iniT;
    public GameObject ast;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int r = Random.Range(0, 3);

        if (Time.time > iniT)
        {
                Instantiate(ast, transform.position, transform.rotation);
                iniT = Time.time + cdTime[r];
            
           
        }
    }
}
