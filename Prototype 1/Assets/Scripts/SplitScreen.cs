using UnityEngine;

public class SplitScreen : MonoBehaviour
{
    // Assign these in the Inspector.
    public Camera player1Camera;
    public Camera player2Camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set the left half of the screen for Player 1.
        if (player1Camera != null)
        {
            player1Camera.rect = new Rect(0, 0, 0.5f, 1);
        }

        // Set the right half of the screen for Player 2.
        if (player2Camera != null)
        {
            player2Camera.rect = new Rect(0.5f, 0, 0.5f, 1);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}