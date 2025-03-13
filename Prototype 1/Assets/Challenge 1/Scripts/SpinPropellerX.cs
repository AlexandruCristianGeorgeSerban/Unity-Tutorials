using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private Vector3 spin = new Vector3(0, 0, 20);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spin.z * Time.deltaTime * 60);
    }
}
