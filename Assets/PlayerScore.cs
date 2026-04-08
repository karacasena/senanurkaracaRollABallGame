using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public int totalPickups;

    public TMP_Text scoreText;
    public TMP_Text winText;

    void Start()
    {
        winText.text = "";
        UpdateScoreText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            score++;
            UpdateScoreText();

            if (score >= totalPickups)
            {
                winText.text = "YOU WIN!";
            }
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}