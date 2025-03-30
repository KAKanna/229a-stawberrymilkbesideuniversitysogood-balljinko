using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab; 
    public Transform spawnPoint; 
    public TMP_InputField ballInputField; 
    public TMP_Text remainingBallsText; 
    public float spawnDelay = 0.5f; 

    private int remainingBalls = 0; //เก็บจำนวนบอลที่เหลือ

    public void OnClick()
    {
        int count;
        if (int.TryParse(ballInputField.text, out count)) // ตรวตัวเลข
        {
            remainingBalls = count; //กำหนกบอลที่ต้องSpawn
            UpdateRemainingBallsUI();
            ballInputField.gameObject.SetActive(false);
            StartCoroutine(SpawnBalls(count));
        }
    }

    IEnumerator SpawnBalls(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation); 
            remainingBalls--; 
            UpdateRemainingBallsUI(); // อัปเดต UI
            yield return new WaitForSeconds(spawnDelay); // รอบอล
        }

        ballInputField.gameObject.SetActive(true);
        ballInputField.text = ""; //กุก็หาตั่งนาน สรุปมันต้อง .textด้วย ครวบ
    }

    void UpdateRemainingBallsUI()
    {
        remainingBallsText.text = $"Remaining: {remainingBalls}";
    }
}
