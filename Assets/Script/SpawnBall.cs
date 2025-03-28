using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject Ball;
    public Transform spawnPoint;
    
    
    public void OnClick()
    {
        spawnBall();
    }
    
    void spawnBall()
    {
        Instantiate(Ball, spawnPoint.position, spawnPoint.rotation);
    }




}
