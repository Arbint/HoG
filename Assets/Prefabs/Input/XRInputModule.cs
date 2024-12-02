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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
