using UnityEngine;

[RequireComponent (typeof(LineRenderer))]
public class LaserPointer : MonoBehaviour
{
    LineRenderer _lineRenderer;
    [SerializeField] float laserTraceDistance = 200f;
    [SerializeField] LayerMask laserTraceMask;

    public RaycastHit Hit
    {
        get => _hit;
        private set => _hit = value;
    }

    RaycastHit _hit;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineEnd = transform.position + transform.forward * laserTraceDistance;
        if(Physics.Raycast(transform.position, transform.forward, out _hit, laserTraceDistance, laserTraceMask))
        {
            lineEnd = _hit.point;
        }
        _lineRenderer.SetPositions(new Vector3[] {transform.position, lineEnd});
    }
}
