using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    #region Public
    public float speedV = 2.0f;
    public float speedH = 2.0f;
    #endregion

    #region Private
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;
    #endregion

    void Update() 
    {

        rotationY += speedV * Input.GetAxis("Mouse X");
        rotationX -= speedH * Input.GetAxis("Mouse Y");

        rotationX = Mathf.Clamp(rotationX, -60, 60);
        rotationY = Mathf.Clamp(rotationY, -90, 90);

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
