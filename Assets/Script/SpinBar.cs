using UnityEngine;

public class SpinBar : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float torque;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddTorque(0, 0, torque);
    }
}
