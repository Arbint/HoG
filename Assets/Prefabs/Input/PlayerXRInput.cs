using UnityEngine.InputSystem;

public enum EXRHandSide
{
    Left,
    Right
}

public struct XRHandActions
{
    public InputAction Position;
    public InputAction Rotation;
    public InputAction Thumbstick;
    public InputAction Trigger;
    public InputAction TriggerButton;
    public InputAction Grip;
    public InputAction GripButton;
    public InputAction PrimaryButton;
    public InputAction SecondaryButton;
}

public class PlayerXRInput : PlayerInput
{
    public XRHandActions GetXRHandActions(EXRHandSide side)
    {
        XRHandActions newActions = new XRHandActions();
         if (side == EXRHandSide.Left)
        {
            newActions.Position = LeftXRController.Position; 
            newActions.Rotation = LeftXRController.Rotation;
            newActions.Thumbstick = LeftXRController.Thumbstick;
            newActions.Trigger = LeftXRController.Trigger;
            newActions.TriggerButton = LeftXRController.TriggerButton;
            newActions.Grip = LeftXRController.Grip;
            newActions.GripButton = LeftXRController.GripButton;
            newActions.PrimaryButton = LeftXRController.PrimaryButton;
            newActions.SecondaryButton = LeftXRController.SecondaryButton;
        }
        else
        {
            newActions.Position = RightXRController.Position; 
            newActions.Rotation = RightXRController.Rotation;
            newActions.Thumbstick = RightXRController.Thumbstick;
            newActions.Trigger = RightXRController.Trigger;
            newActions.TriggerButton = RightXRController.TriggerButton;
            newActions.Grip = RightXRController.Grip;
            newActions.GripButton = RightXRController.GripButton;
            newActions.PrimaryButton = RightXRController.PrimaryButton;
            newActions.SecondaryButton = RightXRController.SecondaryButton;
        }

        return newActions; 
    }
}
