using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRController : MonoBehaviour
{
    [SerializeField] EXRHandSide handSide;

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
        }
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
