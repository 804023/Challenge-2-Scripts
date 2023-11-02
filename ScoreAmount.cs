using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAmount : MonoBehaviour
{
    public int numerator = 0;
    public static int denominator = 0;
    //public static int score = numerator / denominator;
    Text MyScore;
    // Start is called before the first frame update
    void Start()
    {
        MyScore.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        MyScore.text = "Score: " + numerator;
    }
}
