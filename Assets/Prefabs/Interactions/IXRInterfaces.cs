using UnityEngine;

public interface IGrabbable
{
    public void GrabbedBy(GameObject grabber, Vector3 grabPoint);
    public void Released();
}
