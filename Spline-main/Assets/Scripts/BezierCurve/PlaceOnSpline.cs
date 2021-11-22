using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceOnSpline : MonoBehaviour
{
    
    public SplineBest _spline;
    private float _distance = 0f;
    public float _step = 0.001f;
    public float speed = 0.1f;
    public Vector3 direction = Vector3.zero;

    void Start() 
    {
        
    }

    void Update() 
    {
        if(_spline != null)
        {
            _distance = _distance + speed * Time.deltaTime;
            if(_distance > _spline.length())
            {
                _distance = 0f;
            }

            transform.position = _spline.transform.TransformPoint(_spline.computePointWithLength(_distance));
            Debug.DrawLine(transform.position, transform.position + _spline.transform.TransformDirection(direction), Color.red, Time.deltaTime);
        }
    }
    
}
