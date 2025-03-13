using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day (in seconds)")]
    public float dayDurationSeconds = 120f;

    void Update()
    {
        // Calculate how many degrees to rotate per second for a full 360° rotation in dayDurationSeconds
        float rotationDegreesPerSecond = 360f / dayDurationSeconds;
        // Rotate around the X-axis to simulate the sun rising and setting
        transform.Rotate(rotationDegreesPerSecond * Time.deltaTime, 0f, 0f);
    }
}