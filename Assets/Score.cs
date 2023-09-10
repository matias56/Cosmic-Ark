using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static float score;
    public static float curScore;
    public Text s;
    public static float health;
    public Text l;
    // Start is called before the first frame update
    void Start()
    {
        curScore = 0;
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        s.text = "Score: " + score;
        l.text = health.ToString();

        if (health <= 0)
        {
            Time.timeScale = 0;
        }


        if(curScore == 500)
        {
            SceneManager.LoadScene(2);
        }
        else if(curScore == 2000)
        {
            SceneManager.LoadScene(1);
        }
    }
}
