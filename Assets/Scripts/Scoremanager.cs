using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoremanager : MonoBehaviour
{
   
    public float Scorepersecond = 20;
    float score = 0;
    float highscore = 0;

    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI finalscoretext;
    public TextMeshProUGUI highscoretext;

    // Start is called before the first frame update

    private void Start()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        highscoretext.text = "Highscore:" + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score += Scorepersecond * Time.deltaTime;
        scoretext.text = "score:" + Mathf.RoundToInt(score).ToString();
        finalscoretext.text = "score:" + Mathf.RoundToInt(score).ToString();
    
        if(score > highscore)
        {
            highscore = score;
            highscoretext.text = "Highscore:" + Mathf.RoundToInt(highscore).ToString();
            PlayerPrefs.SetFloat("Highscore", highscore);
            PlayerPrefs.Save();

        }

    }
}
    

