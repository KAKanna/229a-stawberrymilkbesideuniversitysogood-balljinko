using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    private Rigidbody rb;
    public int _score; // คะแนนรวม
    [SerializeField] private int _thisscore; // คะแนนของบล็อกนี้
    public TextMeshProUGUI scoreTxt; // UI แสดงคะแนน

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UpdateScoreText(); // อัปเดตคะแนนตอนเริ่มเกม
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball") && this.gameObject.CompareTag("2Score"))
        {
            _score += 2;
            UpdateScoreText(); // อัปเดต UI
            Debug.Log($"Score Updated: {_score}");

            Destroy(other.gameObject); 
        }
        else if (other.gameObject.CompareTag("Ball") && this.gameObject.CompareTag("1Score"))
        {
            _score += 1;
            UpdateScoreText(); // อัปเดต UI
            Debug.Log($"Score Updated: {_score}");
        }
        else if (other.gameObject.CompareTag("Ball") && this.gameObject.CompareTag("0Score"))
        {
            _score += 0;
            UpdateScoreText(); // อัปเดต UI
            Debug.Log($"Score Updated: {_score}");
        }

        //444
    }

    void UpdateScoreText()
    {
        if (scoreTxt != null)
        {
            scoreTxt.text = $"SCORE: {_score}";
        }
    }
}
