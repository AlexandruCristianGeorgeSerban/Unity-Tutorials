using UnityEngine;

public class PlayerControllerP2 : MonoBehaviour
{
    // Private Variables
    private float speed = 5.0f;
    private float turnSpeed = 25;
    private float horizontal2Input;
    private float forward2Input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontal2Input = Input.GetAxis("Horizontal2");
        forward2Input = Input.GetAxis("Vertical2");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forward2Input);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontal2Input);

    }
}
