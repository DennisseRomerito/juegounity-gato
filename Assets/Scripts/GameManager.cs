using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{
    public int score;
    public Text textScore;

    public void AddScore()
    {
        score++;
        textScore.text = score.ToString();
    }

}


// la miss aún no hace nada