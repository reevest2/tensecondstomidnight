using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + scoreAmount;
    }

    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (scoreAmount > currentHighScore)
        {
            PlayerPrefs.SetInt("HighScore", Mathf.FloorToInt(scoreAmount));
        }
    }

}
