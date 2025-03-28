using UnityEngine;

public class CollectPoint : MonoBehaviour
{   

    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
        }
    }
}
