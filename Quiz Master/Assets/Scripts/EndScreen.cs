using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;

    Score score;

    void Awake()
    {
        score = FindObjectOfType<Score>();
    }


    public void showScore(){
        if (score.calculateTotalScore() < 70){
            finalScoreText.text = "Kamu belum berhasil :(  \n yuk semangat belajar dan bermain lagi \n NIlai Anda: " + score.calculateTotalScore();
        }
        else {
            finalScoreText.text = "Horee!! Kamu berhasil \n NIlai Anda: " + score.calculateTotalScore();
        }
        
    }

}
