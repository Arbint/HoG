using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IXRPointer
{
    public Vector2 GetPointerScreenPosition();
}

public class XRInputModule : PointerInputModule
{
    PointerEventData _leftPointerEventData;
    PointerEventData _rightPointerEventData;

    IXRPointer _leftPointerInterface;
    IXRPointer _rightPointerInterface;

    PlayerInput _playerInput;

    public override void Process()
    {
        //..
    }

    protected override void Awake()
    {
        base.Awake();
        if(_playerInput == null)
        {
            _playerInput = new PlayerInput();
        }
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        if(_playerInput != null)
        {
            _playerInput.Enable();
        }
    }

    protected override void OnDisable()
    {
        if(_playerInput != null)
        {
            _playerInput.Disable();
        }
        base.OnDisable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();

        Player player = GameplayStatics.GetPlayer();
        if(player)
        {
            _leftPointerInterface = player.GetLeftPointerInteface();
            _rightPointerInterface = player.GetRightPointerInteface();
        }

        _leftPointerEventData = new PointerEventData(eventSystem);
        _rightPointerEventData = new PointerEventData(eventSystem);

        BindInput();
    }

    private void BindInput()
    {
        if(_playerInput != null)
        {
            _playerInput.LeftXRController.Position.performed += (context) => ProcessPointerMove(_leftPointerInterface, _leftPointerEventData);
            _playerInput.LeftXRController.Trigger.performed += (context) => ProcessPointerDown(_leftPointerInterface, _leftPointerEventData);
            _playerInput.LeftXRController.Trigger.canceled += (context) => ProcessPointerUp(_leftPointerInterface, _leftPointerEventData);

            _playerInput.RightXRController.Position.performed += (context) => ProcessPointerMove(_rightPointerInterface, _rightPointerEventData);
            _playerInput.RightXRController.Trigger.performed += (context) => ProcessPointerDown(_rightPointerInterface, _rightPointerEventData);
            _playerInput.RightXRController.Trigger.canceled += (context) => ProcessPointerUp(_rightPointerInterface, _rightPointerEventData);
        }
    }

    private void ProcessPointerUp(IXRPointer pointerInterface, PointerEventData pointerEventData)
    {
        
    }

    private void ProcessPointerDown(IXRPointer pointerInterface, PointerEventData pointerEventData)
    {
        if (pointerInterface == null || pointerEventData == null)
            return;

        Vector2 pointerScreenPos = pointerInterface.GetPointerScreenPosition();
        pointerEventData.position = pointerScreenPos;
        pointerEventData.pointerCurrentRaycast = GetRaycastResultFromEventData(pointerEventData);

        GameObject pointerDownGameObject = ExecuteEvents.GetEventHandler<IPointerDownHandler>(pointerEventData.pointerCurrentRaycast.gameObject); 
        if(pointerDownGameObject)
        {
            pointerEventData.pointerPress = pointerDownGameObject;
            pointerEventData.pointerPressRaycast = pointerEventData.pointerCurrentRaycast;
            pointerEventData.eligibleForClick = true;

            ExecuteEvents.Execute(pointerDownGameObject, pointerEventData, ExecuteEvents.pointerDownHandler);
        }
    }

    private void ProcessPointerMove(IXRPointer pointerInterface, PointerEventData pointerEventData)
    {

    }

    RaycastResult GetRaycastResultFromEventData(PointerEventData pointerEventData)
    {
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        eventSystem.RaycastAll(pointerEventData, raycastResults);
        return FindFirstRaycast(raycastResults);
    }
}
