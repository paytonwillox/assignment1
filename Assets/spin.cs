using UnityEngine;

public class SpinCube : MonoBehaviour
{
    public float rotationSpeed = 50f; // Adjust this value in the Inspector

    void Update()
    {
        // Rotate the cube around its local Y-axis at a continuous speed
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}