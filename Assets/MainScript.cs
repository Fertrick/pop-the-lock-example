using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text ScoreCounter;
    int score = 0;

    public void addScore()
    {
        score++;
        ScoreCounter.text = score.ToString();
    }
}
