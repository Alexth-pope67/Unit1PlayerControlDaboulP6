using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Adjust the speed in the Inspector
    public float rotationSpeed = 1000f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the GameObject around its local Z-axis
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
