using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] XRController leftHandController;
    [SerializeField] XRController rightHandController;

    PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    internal IXRPointer GetLeftPointerInteface()
    {
        return leftHandController;
    }

    internal IXRPointer GetRightPointerInteface()
    {
        return rightHandController;
    }
}

