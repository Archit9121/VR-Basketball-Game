using UnityEngine;
using UnityEngine.UI; // Works with com.unity.ugui (Unity UI 1.0.0)

public class GameOverScoreDisplay : MonoBehaviour
{
    // Reference to your ScoreAbsorber script
    private ScoreAbsorber scoreAbsorber;

    // Reference to the Text UI component
    private Text scoreText;

    void Start()
    {
        // Find the ScoreAbsorber in the scene (make sure there is one!)
        scoreAbsorber = FindObjectOfType<ScoreAbsorber>();

        // Get the Text component attached to this GameObject
        scoreText = GetComponent<Text>();

        // Optional: safety check
        if (scoreText == null)
        {
            Debug.LogError("GameOverScoreDisplay: No Text component found on this GameObject!");
        }
        if (scoreAbsorber == null)
        {
            Debug.LogError("GameOverScoreDisplay: No ScoreAbsorber found in the scene!");
        }
    }

    void Update()
    {
        if (scoreAbsorber != null && scoreText != null)
        {
            scoreText.text = "Score: " + scoreAbsorber.score;
        }
    }
}
