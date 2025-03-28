using UnityEngine;
using UnityEngine.InputSystem;

public class BarController : MonoBehaviour
{
    public float xRange = 10;
    public float speed;

    private float horizontalInput;
    private InputAction moveAction;
    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = moveAction.ReadValue<Vector2>().x;
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        /*
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }*/
        float clampedX = Mathf.Clamp(transform.position.x, -xRange, xRange);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

    }
}
