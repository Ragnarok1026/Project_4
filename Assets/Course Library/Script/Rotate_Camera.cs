using UnityEngine;

public class Rotate_Camera : MonoBehaviour
{
    public float rotationSpeed;

    void Start()
    {

    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
