using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    private int scoreTotal;
    private Text scoreTotalText;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreTotalText = GameObject.Find("Canvas/ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(int score)
    {
        scoreTotal += score;
        Debug.Log("score total : " + scoreTotal);
        scoreTotalText.text = "Score: " + scoreTotal.ToString();
    }

    
}
