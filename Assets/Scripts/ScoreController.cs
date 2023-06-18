using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreTxt;
    public Text finalTxt;
    public static float scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        scoreTxt.text = scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = scoreValue.ToString();
        finalTxt.text = scoreValue.ToString();
        float bestScore = PlayerPrefs.GetFloat("bestScore");
        if(bestScore<scoreValue){
            PlayerPrefs.SetFloat("bestScore", scoreValue);
        }
        

    }
}
