using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreUI;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ScoreUp")
        {
            score++;
        }
    }

}