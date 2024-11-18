using System;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    Vector3 _linearVelocity;
    Vector3 _angularVelocity;

    Vector3 _prevPos;
    Quaternion _prevRot;

    public Vector3 LinearVelocity
    {
        get => _linearVelocity;
        private set => _linearVelocity = value;
    }
    public Vector3 AngularVelocity
    {
        get => _angularVelocity;
        private set => _angularVelocity = value;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _prevPos = transform.position; 
        _prevRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        CalculateLinearVelocity();
        CalculateAngularVelocity();
    }

    private void CalculateAngularVelocity()
    {
        Quaternion rotDelta = transform.rotation * Quaternion.Inverse(_prevRot);
        _prevRot = transform.rotation;

        rotDelta.ToAngleAxis(out float angle, out Vector3 axis);
        if(angle < float.Epsilon)
        {
            _angularVelocity = Vector3.zero;
            return;
        }

        _angularVelocity = (angle / Time.deltaTime) * axis;
    }

    private void CalculateLinearVelocity()
    {
        Vector3 positionDelta = transform.position - _prevPos;
        _prevPos = transform.position;

        if (positionDelta.sqrMagnitude < float.Epsilon)
        {
            _linearVelocity = Vector3.zero;
            return;
        }
            
        _linearVelocity = positionDelta / Time.deltaTime;
    }
}
