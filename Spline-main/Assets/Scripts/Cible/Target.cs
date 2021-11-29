using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    #region API
    public void Hit()
    {
        transform.position = TargetBounds.Instance.GetPosition();
    }
    #endregion
}
