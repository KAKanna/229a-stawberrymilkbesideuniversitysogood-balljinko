using UnityEngine;
using TMPro;

public class ScoreManagerV2 : MonoBehaviour
{
    public static ScoreManagerV2 Instance;
    public int totalScore = 0;
    public TextMeshProUGUI scoreTxt;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void AddScore(int amount)
    {
        totalScore += amount;
        UpdateScoreText();
        Debug.Log($" Updated: {totalScore}"); //เช็คดีบัก
    }

    void UpdateScoreText()
    {
        if (scoreTxt != null) //เช็คนูล ว่าได้ใส่ไหม
        {
            scoreTxt.text = $"SCORE: {totalScore}";
        }
    }
}