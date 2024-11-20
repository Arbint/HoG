using UnityEngine;

public class Car : Threat
{
    [SerializeField] Transform[] laneTransforms;
    public override void GrabbedBy(GameObject grabber, Vector3 grabPoint)
    {
        Debug.Log($"dragging: {gameObject.name}");
    }

    public override void Released()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
