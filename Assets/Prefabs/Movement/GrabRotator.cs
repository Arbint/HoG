using UnityEngine;

public class GrabRotator : MonoBehaviour, IGrabbable
{
    [SerializeField] Transform rotPivot;
    [SerializeField] Transform transformToRotate;

    GameObject piningObject;

    GameObject _grabber;

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
            rotPivot.LookAt(piningObject.transform);
        }
    }
}
