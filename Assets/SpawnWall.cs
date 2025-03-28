using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    [SerializeField]private GameObject Wall;
    [SerializeField]private Transform spawnPoint;
    private void Start()
    {
        spawnPoint = GetComponent<Transform>();
        spawnWall();
    }
    void spawnWall()
    {
        Instantiate(Wall, spawnPoint.position, spawnPoint.rotation);
    }
}
