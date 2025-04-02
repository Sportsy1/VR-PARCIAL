using Oculus.Interaction;
using UnityEngine;

public class ConstrainerTouch : MonoBehaviour
{
    [SerializeField]
    private OneGrabTranslateTransformer _constrainValues;
    [SerializeField]
    private bool xAxis, yAxis, zAxis;
    private Vector3 constrainMax;
    private Vector3 constrainMin;
    private Vector3 newPosition;
    private void Awake()
    {
        constrainMin = new Vector3(_constrainValues.Constraints.MinX.Value, _constrainValues.Constraints.MinY.Value, _constrainValues.Constraints.MinZ.Value);
        constrainMax = new Vector3(_constrainValues.Constraints.MaxX.Value, _constrainValues.Constraints.MaxY.Value, _constrainValues.Constraints.MaxZ.Value);
    }

    private void FixedUpdate()
    {
        newPosition = transform.localPosition;

        if (xAxis)
        {
            newPosition.x = Mathf.Clamp(newPosition.x,constrainMin.x,constrainMax.x);
            transform.localPosition = newPosition;
        }

        if (yAxis)
        {
            newPosition.y = Mathf.Clamp(newPosition.y,constrainMin.y,constrainMax.y);
            transform.localPosition = newPosition;
        }

        if (zAxis)
        {
            newPosition.z = Mathf.Clamp(newPosition.z,constrainMin.z,constrainMax.z);
            transform.localPosition = newPosition;
        }
    }

}
