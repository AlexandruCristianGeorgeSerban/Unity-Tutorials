using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    // Define two camera offsets.
    private Vector3 offsetDefault = new Vector3(0, 5, -7);
    private Vector3 offsetAlternate = new Vector3(0, 2, 1);

    public GameObject player2;

    // This will hold the current active offset.
    private Vector3 currentOffset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize with the default offset.
        currentOffset = offsetDefault;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // When the jump button is pressed, toggle the offset.
        if (Input.GetButtonDown("P2Camera"))
        {
            // Toggle between the two offsets.
            if (currentOffset == offsetDefault)
            {
                currentOffset = offsetAlternate;
            }
            else
            {
                currentOffset = offsetDefault;
            }
        }

        // Update the camera's position relative to the player's position.
        transform.position = player2.transform.position + currentOffset;
    }
}
