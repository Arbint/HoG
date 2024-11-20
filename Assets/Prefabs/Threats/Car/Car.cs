using System.Linq;
using UnityEditor.Searcher;
using UnityEngine;

public class Car : Threat
{
    [SerializeField] Transform[] laneTransforms;
    [SerializeField] float laneRotGap = 6.5f;
    [SerializeField] Transform carPivot;
    [SerializeField] float changeLaneLerpRate = 10f;
    [SerializeField] LayerMask roadBlockerDetectionLayer;

    GameObject dragPoint = null;
    Transform _goalLane;

    protected override void Awake()
    {
        base.Awake();
        dragPoint = new GameObject($"{gameObject.name}_drag_point");
    }

    public override void GrabbedBy(GameObject grabber, Vector3 grabPoint)
    {
        dragPoint.transform.parent = grabber.transform;
        dragPoint.transform.position = grabPoint;
    }

    public override void Released()
    {
        dragPoint.transform.parent = null;
    }

    private void OnDestroy()
    {
        Destroy(dragPoint);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dragPoint.transform.parent != null)
        {
            float closestDistance = Vector3.Distance(dragPoint.transform.position, laneTransforms[0].position);
            Transform closestLaneTransform = laneTransforms[0];

            for(int i = 1; i < laneTransforms.Length; ++i)
            {
                Transform laneTransform = laneTransforms[i];
                float distance = Vector3.Distance(laneTransform.position, dragPoint.transform.position);
                if (distance < closestDistance)
                { 
                     closestDistance = distance;
                    closestLaneTransform = laneTransform;
                }
            }
            if(!IsLaneBlocked(closestLaneTransform))
                _goalLane = closestLaneTransform;
        }

        if(_goalLane)
        {
            carPivot.rotation = Quaternion.Slerp(carPivot.rotation, _goalLane.rotation, Time.deltaTime * changeLaneLerpRate);
        }
    }

    bool IsLaneBlocked(Transform laneTransform)
    {
        BoxCollider carCollider = GetComponentInChildren<BoxCollider>();

        Quaternion laneRotationDelta = laneTransform.rotation * Quaternion.Inverse(carPivot.rotation);
        laneRotationDelta.ToAngleAxis(out float angle, out Vector3 axis);
        int lanesCount = (int)(angle/laneRotGap);
        for (int i = 1; i < lanesCount; i++)
        {
            Vector3 nextLaneLoc = Quaternion.AngleAxis(i * laneRotGap, axis) * carPivot.position;
            Quaternion nextLaneRot = Quaternion.AngleAxis(i * laneRotGap, axis) * carPivot.rotation;
            if(IsLocationBlocked(nextLaneLoc, carCollider.size/2f,nextLaneRot, new GameObject[] { carCollider.gameObject}))
            {
                return true;
            }
        }

        return false;
    }

    bool IsLocationBlocked(Vector3 position, Vector3 extend, Quaternion rotation, GameObject[] objectsToIgnore)
    {
        Collider[] collidersInLane = Physics.OverlapBox(position, extend, rotation, roadBlockerDetectionLayer);
        foreach(Collider collider in collidersInLane)
        {
            Debug.Log($"Checking against blocker: {collider.gameObject.name}");
            if (!objectsToIgnore.Contains(collider.gameObject))
            {
                return true;
            }
        }

        return false;
    }
}
