//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.1
//     from Assets/Prefabs/Input/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""RightXRController"",
            ""id"": ""ac9a0513-6003-4f5a-a0e6-f7e8ed694b2d"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""45f8c144-f4eb-4343-92b3-f6d075dd0808"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""21fd79ee-acff-408f-87e3-e52b476a4a12"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Thumbstick"",
                    ""type"": ""Value"",
                    ""id"": ""46180ff4-d93f-47e1-8de8-b4067624b0d6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""b68a460b-9028-479d-bfe3-e1adb2363fda"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TriggerButton"",
                    ""type"": ""Button"",
                    ""id"": ""88fc186c-23ed-47d2-a0ca-7ab2a9a3a190"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grip"",
                    ""type"": ""Value"",
                    ""id"": ""5f978e1e-0104-425f-b0c9-692ad6af8767"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GripButton"",
                    ""type"": ""Button"",
                    ""id"": ""85ab7abf-4030-4435-8782-da30e56ff3b3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""0cfb361d-084f-43db-a8ee-8d1235a315e0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""9997da2d-6d43-4874-9a96-c723975b7f35"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1fbb4d1a-faf3-4cfc-9d51-7b7cde30090d"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4aa6f707-93a7-49e5-ba02-7147ea9049bc"",
                    ""path"": ""<XRController>{RightHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32149896-256a-4766-9efb-c3e8873448f5"",
                    ""path"": ""<XRController>{RightHand}/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thumbstick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9db93fb2-9401-4feb-8d43-9001a0184ebe"",
                    ""path"": ""<XRController>{RightHand}/{Trigger}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a957b2ba-43a7-4e8c-bd74-54bb81bcf290"",
                    ""path"": ""<XRController>{RightHand}/{TriggerButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c742ce4-2c49-400d-8751-e9021aa629f6"",
                    ""path"": ""<XRController>{RightHand}/{Grip}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05e88eb1-0da2-43d5-b4f8-fa194147d57e"",
                    ""path"": ""<XRController>{RightHand}/{GripButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0f62091-3341-4110-a788-fe6e401cc86c"",
                    ""path"": ""<XRController>{RightHand}/{PrimaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6c92484-bbd1-4407-aa94-f54b136368c6"",
                    ""path"": ""<XRController>{RightHand}/{SecondaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftXRController"",
            ""id"": ""e7605dfd-98ae-425c-8708-aa604d9549af"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""ee292256-98ff-484c-b58b-6bc5a47f6cbb"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""3891b01b-36be-48d0-aae1-9faa81e4f63e"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Thumbstick"",
                    ""type"": ""Value"",
                    ""id"": ""393af91c-e379-4286-8378-4302e48a53b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""1d031871-65b7-4d7d-8de1-e71dd00a78d9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TriggerButton"",
                    ""type"": ""Button"",
                    ""id"": ""18ff2cc6-9809-4568-a72e-6aadc3c2069c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grip"",
                    ""type"": ""Value"",
                    ""id"": ""c02caddd-71c1-47af-a0ab-99ff78b52e83"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GripButton"",
                    ""type"": ""Button"",
                    ""id"": ""d34af1b4-1a5b-400e-b6e0-d9d0b97a7324"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""8b4193b4-cab7-45c3-bb6d-bcf1ca456f30"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""ac2a6933-d564-464d-b777-94b18f0ebbac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e72a383-a470-4e9f-8054-e27e4ab5554a"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8bfb158-d247-4555-9a5c-103673bd2efa"",
                    ""path"": ""<XRController>{LeftHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25971eef-88c3-4d5a-858a-8bba117ea866"",
                    ""path"": ""<XRController>{LeftHand}/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thumbstick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbc9923a-96cb-4edc-bf1a-f10800a78e4d"",
                    ""path"": ""<XRController>{LeftHand}/{Trigger}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d27d87d-d845-4e0f-8b5e-9e94b1f9734a"",
                    ""path"": ""<XRController>{LeftHand}/{TriggerButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e380c1f1-b942-40c5-8474-856c22d7a86c"",
                    ""path"": ""<XRController>{LeftHand}/{Grip}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b83b2909-6715-4f42-a1b3-aacdc8a48516"",
                    ""path"": ""<XRController>{LeftHand}/{GripButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe58fe7b-0546-4bc2-a537-5ba0ccd0fa4d"",
                    ""path"": ""<XRController>{LeftHand}/{PrimaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27174916-ceac-4b86-9f49-0fa423a35fff"",
                    ""path"": ""<XRController>{LeftHand}/{SecondaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RightXRController
        m_RightXRController = asset.FindActionMap("RightXRController", throwIfNotFound: true);
        m_RightXRController_Position = m_RightXRController.FindAction("Position", throwIfNotFound: true);
        m_RightXRController_Rotation = m_RightXRController.FindAction("Rotation", throwIfNotFound: true);
        m_RightXRController_Thumbstick = m_RightXRController.FindAction("Thumbstick", throwIfNotFound: true);
        m_RightXRController_Trigger = m_RightXRController.FindAction("Trigger", throwIfNotFound: true);
        m_RightXRController_TriggerButton = m_RightXRController.FindAction("TriggerButton", throwIfNotFound: true);
        m_RightXRController_Grip = m_RightXRController.FindAction("Grip", throwIfNotFound: true);
        m_RightXRController_GripButton = m_RightXRController.FindAction("GripButton", throwIfNotFound: true);
        m_RightXRController_PrimaryButton = m_RightXRController.FindAction("PrimaryButton", throwIfNotFound: true);
        m_RightXRController_SecondaryButton = m_RightXRController.FindAction("SecondaryButton", throwIfNotFound: true);
        // LeftXRController
        m_LeftXRController = asset.FindActionMap("LeftXRController", throwIfNotFound: true);
        m_LeftXRController_Position = m_LeftXRController.FindAction("Position", throwIfNotFound: true);
        m_LeftXRController_Rotation = m_LeftXRController.FindAction("Rotation", throwIfNotFound: true);
        m_LeftXRController_Thumbstick = m_LeftXRController.FindAction("Thumbstick", throwIfNotFound: true);
        m_LeftXRController_Trigger = m_LeftXRController.FindAction("Trigger", throwIfNotFound: true);
        m_LeftXRController_TriggerButton = m_LeftXRController.FindAction("TriggerButton", throwIfNotFound: true);
        m_LeftXRController_Grip = m_LeftXRController.FindAction("Grip", throwIfNotFound: true);
        m_LeftXRController_GripButton = m_LeftXRController.FindAction("GripButton", throwIfNotFound: true);
        m_LeftXRController_PrimaryButton = m_LeftXRController.FindAction("PrimaryButton", throwIfNotFound: true);
        m_LeftXRController_SecondaryButton = m_LeftXRController.FindAction("SecondaryButton", throwIfNotFound: true);
    }

    ~@PlayerInput()
    {
        UnityEngine.Debug.Assert(!m_RightXRController.enabled, "This will cause a leak and performance issues, PlayerInput.RightXRController.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_LeftXRController.enabled, "This will cause a leak and performance issues, PlayerInput.LeftXRController.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // RightXRController
    private readonly InputActionMap m_RightXRController;
    private List<IRightXRControllerActions> m_RightXRControllerActionsCallbackInterfaces = new List<IRightXRControllerActions>();
    private readonly InputAction m_RightXRController_Position;
    private readonly InputAction m_RightXRController_Rotation;
    private readonly InputAction m_RightXRController_Thumbstick;
    private readonly InputAction m_RightXRController_Trigger;
    private readonly InputAction m_RightXRController_TriggerButton;
    private readonly InputAction m_RightXRController_Grip;
    private readonly InputAction m_RightXRController_GripButton;
    private readonly InputAction m_RightXRController_PrimaryButton;
    private readonly InputAction m_RightXRController_SecondaryButton;
    public struct RightXRControllerActions
    {
        private @PlayerInput m_Wrapper;
        public RightXRControllerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_RightXRController_Position;
        public InputAction @Rotation => m_Wrapper.m_RightXRController_Rotation;
        public InputAction @Thumbstick => m_Wrapper.m_RightXRController_Thumbstick;
        public InputAction @Trigger => m_Wrapper.m_RightXRController_Trigger;
        public InputAction @TriggerButton => m_Wrapper.m_RightXRController_TriggerButton;
        public InputAction @Grip => m_Wrapper.m_RightXRController_Grip;
        public InputAction @GripButton => m_Wrapper.m_RightXRController_GripButton;
        public InputAction @PrimaryButton => m_Wrapper.m_RightXRController_PrimaryButton;
        public InputAction @SecondaryButton => m_Wrapper.m_RightXRController_SecondaryButton;
        public InputActionMap Get() { return m_Wrapper.m_RightXRController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightXRControllerActions set) { return set.Get(); }
        public void AddCallbacks(IRightXRControllerActions instance)
        {
            if (instance == null || m_Wrapper.m_RightXRControllerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RightXRControllerActionsCallbackInterfaces.Add(instance);
            @Position.started += instance.OnPosition;
            @Position.performed += instance.OnPosition;
            @Position.canceled += instance.OnPosition;
            @Rotation.started += instance.OnRotation;
            @Rotation.performed += instance.OnRotation;
            @Rotation.canceled += instance.OnRotation;
            @Thumbstick.started += instance.OnThumbstick;
            @Thumbstick.performed += instance.OnThumbstick;
            @Thumbstick.canceled += instance.OnThumbstick;
            @Trigger.started += instance.OnTrigger;
            @Trigger.performed += instance.OnTrigger;
            @Trigger.canceled += instance.OnTrigger;
            @TriggerButton.started += instance.OnTriggerButton;
            @TriggerButton.performed += instance.OnTriggerButton;
            @TriggerButton.canceled += instance.OnTriggerButton;
            @Grip.started += instance.OnGrip;
            @Grip.performed += instance.OnGrip;
            @Grip.canceled += instance.OnGrip;
            @GripButton.started += instance.OnGripButton;
            @GripButton.performed += instance.OnGripButton;
            @GripButton.canceled += instance.OnGripButton;
            @PrimaryButton.started += instance.OnPrimaryButton;
            @PrimaryButton.performed += instance.OnPrimaryButton;
            @PrimaryButton.canceled += instance.OnPrimaryButton;
            @SecondaryButton.started += instance.OnSecondaryButton;
            @SecondaryButton.performed += instance.OnSecondaryButton;
            @SecondaryButton.canceled += instance.OnSecondaryButton;
        }

        private void UnregisterCallbacks(IRightXRControllerActions instance)
        {
            @Position.started -= instance.OnPosition;
            @Position.performed -= instance.OnPosition;
            @Position.canceled -= instance.OnPosition;
            @Rotation.started -= instance.OnRotation;
            @Rotation.performed -= instance.OnRotation;
            @Rotation.canceled -= instance.OnRotation;
            @Thumbstick.started -= instance.OnThumbstick;
            @Thumbstick.performed -= instance.OnThumbstick;
            @Thumbstick.canceled -= instance.OnThumbstick;
            @Trigger.started -= instance.OnTrigger;
            @Trigger.performed -= instance.OnTrigger;
            @Trigger.canceled -= instance.OnTrigger;
            @TriggerButton.started -= instance.OnTriggerButton;
            @TriggerButton.performed -= instance.OnTriggerButton;
            @TriggerButton.canceled -= instance.OnTriggerButton;
            @Grip.started -= instance.OnGrip;
            @Grip.performed -= instance.OnGrip;
            @Grip.canceled -= instance.OnGrip;
            @GripButton.started -= instance.OnGripButton;
            @GripButton.performed -= instance.OnGripButton;
            @GripButton.canceled -= instance.OnGripButton;
            @PrimaryButton.started -= instance.OnPrimaryButton;
            @PrimaryButton.performed -= instance.OnPrimaryButton;
            @PrimaryButton.canceled -= instance.OnPrimaryButton;
            @SecondaryButton.started -= instance.OnSecondaryButton;
            @SecondaryButton.performed -= instance.OnSecondaryButton;
            @SecondaryButton.canceled -= instance.OnSecondaryButton;
        }

        public void RemoveCallbacks(IRightXRControllerActions instance)
        {
            if (m_Wrapper.m_RightXRControllerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRightXRControllerActions instance)
        {
            foreach (var item in m_Wrapper.m_RightXRControllerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RightXRControllerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RightXRControllerActions @RightXRController => new RightXRControllerActions(this);

    // LeftXRController
    private readonly InputActionMap m_LeftXRController;
    private List<ILeftXRControllerActions> m_LeftXRControllerActionsCallbackInterfaces = new List<ILeftXRControllerActions>();
    private readonly InputAction m_LeftXRController_Position;
    private readonly InputAction m_LeftXRController_Rotation;
    private readonly InputAction m_LeftXRController_Thumbstick;
    private readonly InputAction m_LeftXRController_Trigger;
    private readonly InputAction m_LeftXRController_TriggerButton;
    private readonly InputAction m_LeftXRController_Grip;
    private readonly InputAction m_LeftXRController_GripButton;
    private readonly InputAction m_LeftXRController_PrimaryButton;
    private readonly InputAction m_LeftXRController_SecondaryButton;
    public struct LeftXRControllerActions
    {
        private @PlayerInput m_Wrapper;
        public LeftXRControllerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_LeftXRController_Position;
        public InputAction @Rotation => m_Wrapper.m_LeftXRController_Rotation;
        public InputAction @Thumbstick => m_Wrapper.m_LeftXRController_Thumbstick;
        public InputAction @Trigger => m_Wrapper.m_LeftXRController_Trigger;
        public InputAction @TriggerButton => m_Wrapper.m_LeftXRController_TriggerButton;
        public InputAction @Grip => m_Wrapper.m_LeftXRController_Grip;
        public InputAction @GripButton => m_Wrapper.m_LeftXRController_GripButton;
        public InputAction @PrimaryButton => m_Wrapper.m_LeftXRController_PrimaryButton;
        public InputAction @SecondaryButton => m_Wrapper.m_LeftXRController_SecondaryButton;
        public InputActionMap Get() { return m_Wrapper.m_LeftXRController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftXRControllerActions set) { return set.Get(); }
        public void AddCallbacks(ILeftXRControllerActions instance)
        {
            if (instance == null || m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces.Add(instance);
            @Position.started += instance.OnPosition;
            @Position.performed += instance.OnPosition;
            @Position.canceled += instance.OnPosition;
            @Rotation.started += instance.OnRotation;
            @Rotation.performed += instance.OnRotation;
            @Rotation.canceled += instance.OnRotation;
            @Thumbstick.started += instance.OnThumbstick;
            @Thumbstick.performed += instance.OnThumbstick;
            @Thumbstick.canceled += instance.OnThumbstick;
            @Trigger.started += instance.OnTrigger;
            @Trigger.performed += instance.OnTrigger;
            @Trigger.canceled += instance.OnTrigger;
            @TriggerButton.started += instance.OnTriggerButton;
            @TriggerButton.performed += instance.OnTriggerButton;
            @TriggerButton.canceled += instance.OnTriggerButton;
            @Grip.started += instance.OnGrip;
            @Grip.performed += instance.OnGrip;
            @Grip.canceled += instance.OnGrip;
            @GripButton.started += instance.OnGripButton;
            @GripButton.performed += instance.OnGripButton;
            @GripButton.canceled += instance.OnGripButton;
            @PrimaryButton.started += instance.OnPrimaryButton;
            @PrimaryButton.performed += instance.OnPrimaryButton;
            @PrimaryButton.canceled += instance.OnPrimaryButton;
            @SecondaryButton.started += instance.OnSecondaryButton;
            @SecondaryButton.performed += instance.OnSecondaryButton;
            @SecondaryButton.canceled += instance.OnSecondaryButton;
        }

        private void UnregisterCallbacks(ILeftXRControllerActions instance)
        {
            @Position.started -= instance.OnPosition;
            @Position.performed -= instance.OnPosition;
            @Position.canceled -= instance.OnPosition;
            @Rotation.started -= instance.OnRotation;
            @Rotation.performed -= instance.OnRotation;
            @Rotation.canceled -= instance.OnRotation;
            @Thumbstick.started -= instance.OnThumbstick;
            @Thumbstick.performed -= instance.OnThumbstick;
            @Thumbstick.canceled -= instance.OnThumbstick;
            @Trigger.started -= instance.OnTrigger;
            @Trigger.performed -= instance.OnTrigger;
            @Trigger.canceled -= instance.OnTrigger;
            @TriggerButton.started -= instance.OnTriggerButton;
            @TriggerButton.performed -= instance.OnTriggerButton;
            @TriggerButton.canceled -= instance.OnTriggerButton;
            @Grip.started -= instance.OnGrip;
            @Grip.performed -= instance.OnGrip;
            @Grip.canceled -= instance.OnGrip;
            @GripButton.started -= instance.OnGripButton;
            @GripButton.performed -= instance.OnGripButton;
            @GripButton.canceled -= instance.OnGripButton;
            @PrimaryButton.started -= instance.OnPrimaryButton;
            @PrimaryButton.performed -= instance.OnPrimaryButton;
            @PrimaryButton.canceled -= instance.OnPrimaryButton;
            @SecondaryButton.started -= instance.OnSecondaryButton;
            @SecondaryButton.performed -= instance.OnSecondaryButton;
            @SecondaryButton.canceled -= instance.OnSecondaryButton;
        }

        public void RemoveCallbacks(ILeftXRControllerActions instance)
        {
            if (m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILeftXRControllerActions instance)
        {
            foreach (var item in m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LeftXRControllerActions @LeftXRController => new LeftXRControllerActions(this);
    public interface IRightXRControllerActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnThumbstick(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
        void OnTriggerButton(InputAction.CallbackContext context);
        void OnGrip(InputAction.CallbackContext context);
        void OnGripButton(InputAction.CallbackContext context);
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
    }
    public interface ILeftXRControllerActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnThumbstick(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
        void OnTriggerButton(InputAction.CallbackContext context);
        void OnGrip(InputAction.CallbackContext context);
        void OnGripButton(InputAction.CallbackContext context);
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
    }
}
