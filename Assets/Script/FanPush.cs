using UnityEngine;

public class FanPush : MonoBehaviour
{
    [SerializeField] private float fanForce = 10f; // กำหนดแรงลม
    [SerializeField] private Vector3 windDirection = Vector3.forward;


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 forceDirection = transform.TransformDirection(windDirection);
                rb.AddForce(forceDirection * fanForce, ForceMode.Acceleration);
            }
        }
    }
}
