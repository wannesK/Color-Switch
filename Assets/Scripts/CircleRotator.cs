using UnityEngine;

public class CircleRotator : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        RotateCircle();
    }
    private void RotateCircle()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
