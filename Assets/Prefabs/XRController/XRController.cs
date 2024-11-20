using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRController : MonoBehaviour
{
    [SerializeField] EXRHandSide handSide;
    [SerializeField] Transform thumbStick;

    [Header("Laser")]
    [SerializeField] LaserPointer laserPointer; 

    [Header("Trigger")]
    [SerializeField] Transform triggerTransform;
    [SerializeField] Vector2 triggerRotRange;

    [Header("Grip")]
    [SerializeField] Transform gripTransform;
    [SerializeField] Vector2 gripOffsetRange;

    [Header("Primary Button")]
    [SerializeField] Transform primaryButtonTransform;
    [SerializeField] Vector2 primaryButtonOffsetRange;

    [Header("Secondary Button")]
    [SerializeField] Transform secondaryButtonTransform;
    [SerializeField] Vector2 secondaryButtonOffsetRange;


    PlayerXRInput _xrInput;

    IGrabbable _currentGabbable;
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

            _xrInput.GetXRHandActions(handSide).Trigger.performed += TriggerUpdated;
            _xrInput.GetXRHandActions(handSide).Trigger.canceled += TriggerUpdated;

            _xrInput.GetXRHandActions(handSide).TriggerButton.performed += TriggerButtonUpdated;
            _xrInput.GetXRHandActions(handSide).TriggerButton.canceled += TriggerButtonUpdated;

            _xrInput.GetXRHandActions(handSide).Grip.performed += GripUpdated;
            _xrInput.GetXRHandActions(handSide).Grip.canceled += GripUpdated;

            _xrInput.GetXRHandActions(handSide).GripButton.performed += GripButtonUpdated;
            _xrInput.GetXRHandActions(handSide).GripButton.canceled += GripButtonUpdated;

            _xrInput.GetXRHandActions(handSide).PrimaryButton.performed += PrimaryButtonUpdated;
            _xrInput.GetXRHandActions(handSide).PrimaryButton.canceled += PrimaryButtonUpdated;

            _xrInput.GetXRHandActions(handSide).SecondaryButton.performed += SecondaryButtonUpdated;
            _xrInput.GetXRHandActions(handSide).SecondaryButton.canceled += SecondaryButtonUpdated;
        }
    }

    private void SecondaryButtonUpdated(InputAction.CallbackContext context)
    {
        float inputVal = context.ReadValue<float>();
        float yOffset = Mathf.Lerp(secondaryButtonOffsetRange.x, secondaryButtonOffsetRange.y, inputVal);
        secondaryButtonTransform.localPosition = new Vector3(secondaryButtonTransform.localPosition.x, yOffset, secondaryButtonTransform.localPosition.z);
    }

    private void PrimaryButtonUpdated(InputAction.CallbackContext context)
    {
        float inputVal = context.ReadValue<float>();
        float yOffset = Mathf.Lerp(primaryButtonOffsetRange.x, primaryButtonOffsetRange.y, inputVal);
        primaryButtonTransform.localPosition = new Vector3(primaryButtonTransform.localPosition.x, yOffset, primaryButtonTransform.localPosition.z);
    }

    private void GripButtonUpdated(InputAction.CallbackContext context)
    {

    }

    private void GripUpdated(InputAction.CallbackContext context)
    {
        float inputVal = context.ReadValue<float>();
        float xOffset = Mathf.Lerp(gripOffsetRange.x, gripOffsetRange.y, inputVal);
        gripTransform.localPosition = new Vector3(xOffset, gripTransform.localPosition.y, gripTransform.localPosition.z);
    }

    private void TriggerButtonUpdated(InputAction.CallbackContext context)
    {
        float inputVal = context.ReadValue<float>();
        if (inputVal != 0f)
        {
            TriggerPressed();
        }
        else
        {
            TriggerReleased();
        }
    }

    private void TriggerReleased()
    {
        if(_currentGabbable as UnityEngine.Object)
        {
            _currentGabbable.Released();
        }

        _currentGabbable = null;
    }

    private void TriggerPressed()
    {
        if(laserPointer.GetLaserHit(out GameObject hitObject, out Vector3 hitPosition))
        {
            _currentGabbable = hitObject.GetComponent<IGrabbable>();  
            if(_currentGabbable == null)
            {
                _currentGabbable = hitObject.GetComponentInParent<IGrabbable>();
            }

            if(_currentGabbable != null)
            {
                _currentGabbable.GrabbedBy(gameObject, hitPosition); 
            }
        }
    }

    private void TriggerUpdated(InputAction.CallbackContext context)
    {
        float inputVal = context.ReadValue<float>();
        float rotX = Mathf.Lerp(triggerRotRange.x, triggerRotRange.y, inputVal);
        triggerTransform.localRotation = Quaternion.Euler(rotX, 0f, 0f);
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
