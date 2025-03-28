using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

                Vector3 initialDirection = new Vector3(Random.Range(-1f, 1f), 0, 1).normalized;
        rb.linearVelocity = initialDirection * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
                        float hitFactor = (transform.position.x - collision.transform.position.x) / (collision.collider.bounds.size.x / 2);
            Vector3 newDirection = new Vector3(hitFactor, 0, 1).normalized;
            rb.linearVelocity = newDirection * speed;
        }
        else
        {
                        Vector3 reflectedVelocity = Vector3.Reflect(rb.linearVelocity, collision.contacts[0].normal);
            rb.linearVelocity = reflectedVelocity;
        }
    }
}
