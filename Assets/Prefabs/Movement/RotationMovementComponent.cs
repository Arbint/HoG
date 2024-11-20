using UnityEngine;

public class RotationMovementComponent : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 20f;
    [SerializeField] Vector3 rotationEulerAxis = Vector3.left;

    private void Update()
    {
        transform.Rotate(rotationEulerAxis * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
