using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public TMP_Text scoreText;
    public static int scoreValue = 0;
    void Update()
    {
        scoreText.text = "Score: " + scoreValue;

    }
}
