using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    private int scoreTotal;
    private Text scoreTotalText;
    private int pourcentage=0;

    private Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreTotalText = GameObject.Find("Canvas/ScoreText").GetComponent<Text>();

        slider = GameObject.Find("Canvas/Slider").GetComponent<Slider>();
        SetMaxBar();
    }


    public void OnClick(int score)
    {
        scoreTotal += score;
        //pourcentage = (scoreTotal/46) * 100;
        scoreTotalText.text = "Score: " + scoreTotal.ToString();
        //scoreTotalText.text = "Score: " + pourcentage.ToString() + "%";
        SetBar();
    }


    public void SetMaxBar()
    {
        slider.maxValue = 46;
    }

    public void SetBar()
    {
        if(slider != null)
            slider.value = scoreTotal;

        else
        {

        }
    }

    
}
