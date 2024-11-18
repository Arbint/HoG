using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRController : MonoBehaviour
{
    [SerializeField] EXRHandSide handSide;
    [SerializeField] Transform thumbStick;

    PlayerXRInput _xrInput;

    private void Awake()
    {
        _xrInput = new PlayerXRInput();
    }

    private void OnEnable()
    {
        if(_xrInput != null)
            _xrInput.Enable();
    }

    private void OnDisable()
    {
        if(_xrInput != null)
            _xrInput.Disable();
    }

    private void Start()
    {
        if(_xrInput != null)
        {
            _xrInput.GetXRHandActions(handSide).Position.performed += PoisitonUpdated;
            _xrInput.GetXRHandActions(handSide).Rotation.performed += RotationUpdated;
            _xrInput.GetXRHandActions(handSide).Thumbstick.performed += ThumbStickUpdated;
            _xrInput.GetXRHandActions(handSide).Thumbstick.canceled += ThumbStickUpdated;
        }
    }

    private void ThumbStickUpdated(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        thumbStick.rotation = transform.localRotation * Quaternion.Euler(input.y * 15, 0f, -input.x * 15);
    }

    private void RotationUpdated(InputAction.CallbackContext context)
    {
        transform.localRotation = context.ReadValue<Quaternion>();
    }

    private void PoisitonUpdated(InputAction.CallbackContext context)
    {
        transform.localPosition = context.ReadValue<Vector3>();
    }
}
