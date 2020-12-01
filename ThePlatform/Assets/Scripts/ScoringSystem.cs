using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoringSystem : MonoBehaviour
{

    public Text ScoreText;
    
    public static int Score;

   


    private void Update()
    {

        ScoreText.GetComponent<Text>().text = "Score : " + Score;

    }

}
