using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject copperCoin;
    public GameObject silverCoin;
    public GameObject goldCoin;
    public Text bestScoreTxt;
    public Text score;

    void Start()
    {
        Time.timeScale = 1;
        copperCoin.SetActive(false);
        silverCoin.SetActive(false);
        goldCoin.SetActive(false);
    }

    public void GameOverActive(){
        float bestScore = PlayerPrefs.GetFloat("bestScore");
        bestScoreTxt.text = bestScore.ToString();
        gameOver.SetActive(true);
        Time.timeScale = 0;
        float finalScore =  float.Parse(score.text);
        if(finalScore>=3){
            copperCoin.SetActive(true);
            if(finalScore>=5){
                copperCoin.SetActive(false);
                silverCoin.SetActive(true);
                if(finalScore>=10){
                    silverCoin.SetActive(false);
                    goldCoin.SetActive(true);
                }
            }
        }
    }

    public void Load(){
        SceneManager.LoadScene(0);
    }
}
