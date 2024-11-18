using UnityEngine;

public class GrabRotator : MonoBehaviour, IGrabbable
{
    [SerializeField] Transform rotPivot;
    [SerializeField] Transform transformToRotate;
    [SerializeField] float turnSpeed = 20f;
    [SerializeField] float rotationDampingRate = 10f;
    GameObject piningObject;
    GameObject _grabber;
    MovementComponent _rotPivotMovementComponent;
    Vector3 _rotPivotAngularVelocity;


    public void GrabbedBy(GameObject grabber, Vector3 grabPoint)
    {
        piningObject.transform.parent = grabber.transform;    
        piningObject.transform.position = grabPoint;
        _grabber = grabber;
        transformToRotate.parent = transform;
        rotPivot.LookAt(piningObject.transform);
        transformToRotate.parent = rotPivot;
    }

    public void Released()
    {
        _grabber = null;
        piningObject.transform.parent = transform;
        _rotPivotAngularVelocity = _rotPivotMovementComponent.AngularVelocity; 
    }

    private void Awake()
    {
        _rotPivotMovementComponent = rotPivot.gameObject.AddComponent<MovementComponent>(); 
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        piningObject = new GameObject($"{gameObject.name}_aim"); 
        piningObject.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
       if(_grabber)
        {
            Quaternion goalRot = Quaternion.LookRotation((piningObject.transform.position-rotPivot.transform.position).normalized);
            rotPivot.rotation = Quaternion.Slerp(rotPivot.rotation, goalRot, Time.deltaTime * turnSpeed);
        }
        else
        {
            rotPivot.rotation = Quaternion.AngleAxis(_rotPivotAngularVelocity.magnitude * Time.deltaTime, _rotPivotAngularVelocity.normalized) * rotPivot.rotation;
            _rotPivotAngularVelocity = Vector3.Slerp(_rotPivotAngularVelocity, Vector3.zero, Time.deltaTime * rotationDampingRate);
        }
    }
}
