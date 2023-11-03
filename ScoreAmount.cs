using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAmount : MonoBehaviour
{
    [SerializeField]
    public Text MyScore;
    [SerializeField]
    public int numerator = 0;
    public static int denominator = 0;
    //public static int score = numerator / denominator;
    
    // Start is called before the first frame update
    void Start()
    {
        MyScore.text = "";
    }

    public void AddScore()
    {
        MyScore.text = "Score: " + numerator;
    }
    // Update is called once per frame
    void Update()
    {
 
    }
}
