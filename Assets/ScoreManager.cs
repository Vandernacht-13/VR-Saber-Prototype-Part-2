
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI comboText;

    private int score = 0;
    private int combo = 0;
    private int highestCombo = 0;

    public int FinalScore => score;
    public int HighestCombo => highestCombo;

    


    void Start()
    {
        UpdateScoreDisplay();
        UpdateComboDisplay();
    }

    public void AddPoints(int points)
    {
        score += points;
        combo++;

        if (combo > highestCombo)
        {
            highestCombo = combo;
        }

        UpdateScoreDisplay();
        UpdateComboDisplay();
    }

    public void ResetCombo()
    {
        combo = 0;
        UpdateComboDisplay();
         Debug.Log("COMBO RESET TO: " + combo);
    }

    void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }

    void UpdateComboDisplay()
    {
        if (comboText != null)
        {
            comboText.text = "Combo: " + combo;
        }
    }
}
