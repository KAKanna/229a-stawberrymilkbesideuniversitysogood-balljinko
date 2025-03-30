using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    public GameObject hitPrefabScore0;
    public GameObject hitPrefabScore1;
    public GameObject hitPrefabScore3;
    public GameObject hitPrefabScore5;
    public GameObject hitPrefabPajinkoBall;

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

        if (collision.gameObject.name == "0 Score")
        {
            if (hitPrefabScore0 != null)
            {
                GameObject effect = Instantiate(hitPrefabScore0, transform.position, Quaternion.identity);
                Destroy(effect, 0.5f);
            }
        }
        if (collision.gameObject.name == "1 Score" || collision.gameObject.name == "1 Score (1)")
        {
            if (hitPrefabScore1 != null)
            {
                GameObject effect = Instantiate(hitPrefabScore1, transform.position, Quaternion.identity);
                Destroy(effect, 0.5f);
            }
        }
        if (collision.gameObject.name == "3 Score" || collision.gameObject.name == "3 Score (1)")
        {
            if (hitPrefabScore3 != null)
            {
                GameObject effect = Instantiate(hitPrefabScore3, transform.position, Quaternion.identity);
                Destroy(effect, 0.5f);
            }
        }
        if (collision.gameObject.name == "5 Score" || collision.gameObject.name == "5 Score (1)")
        {
            if (hitPrefabScore5 != null)
            {
                GameObject effect = Instantiate(hitPrefabScore5, transform.position, Quaternion.identity);
                Destroy(effect, 0.5f);
            }
        }
        if (collision.gameObject.name == "PajinkoBall" || collision.gameObject.name == "PajinkoBall(Clone)")
        {
            if (hitPrefabScore5 != null)
            {
                GameObject effect = Instantiate(hitPrefabPajinkoBall, transform.position, Quaternion.identity);
                Destroy(effect, 0.5f);
            }
        }

        
    }
}
