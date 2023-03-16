 using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreObj : MonoBehaviour
{
    public int score;
    public Spawner Spawner;
    public TMP_Text SkorObject,skorYazi,HighSkorYazi,buttonText;
    public GameObject oyunBittiMenu;



    public int ScoreKazan()
    {
        score += 1;
        SkorObject.SetText(score.ToString());
        return score;

    }
    public void ResetScore()
    {
        score =0;
        SkorObject.SetText("0");
    }

    public void Start()
    {
        skorYazi.SetText("0");
        HighSkorYazi.SetText(PlayerPrefs.GetInt("score").ToString());
    }
    public void EndGame()
    {
        if(PlayerPrefs.GetInt("score") < score)
        {
            PlayerPrefs.SetInt("score", score);
        }

        buttonText.SetText("Tekrar dene");
        skorYazi.SetText(score.ToString());
        HighSkorYazi.SetText(PlayerPrefs.GetInt("score").ToString());
        oyunBittiMenu.SetActive(true);
        Spawner.oyunBasladiMi = false;
    }


     



}
