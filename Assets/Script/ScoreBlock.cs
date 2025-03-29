using UnityEngine;

public class ScoreBlock : MonoBehaviour
{
    [SerializeField] private int blockScore; // score of this block

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball")) //if hit ball
        {
            ScoreManagerV2.Instance.AddScore(blockScore); // add score to mangerv2
            Destroy(other.gameObject);
        }
    }
}