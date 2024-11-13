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
        }
        else
        {
            newActions.Position = RightXRController.Position;
            newActions.Rotation = RightXRController.Rotation;
            newActions.Thumbstick = RightXRController.Thumbstick;
        }

        return newActions; 
    }
}
