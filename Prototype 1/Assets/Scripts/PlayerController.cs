using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 5.0f;
    private float turnSpeed = 25;
    private float horizontal1Input;
    private float forward1Input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontal1Input = Input.GetAxis("Horizontal1");
        forward1Input = Input.GetAxis("Vertical1");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forward1Input);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontal1Input);

    }
}
