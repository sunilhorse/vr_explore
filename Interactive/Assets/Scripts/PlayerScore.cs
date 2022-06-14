using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "basketball")
        {
            score += 1;
            scoreText.text = score.ToString();
        }
    }

    public void resetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score:" + score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score:" + score.ToString();
    }

}
