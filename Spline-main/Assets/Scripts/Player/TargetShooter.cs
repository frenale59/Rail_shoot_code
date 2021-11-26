using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShooter : MonoBehaviour
{
    #region Serialize Fields
    [SerializeField] Camera cam;
    #endregion

    #region API
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();

                if(target != null)
                {
                    Inventory.instance.AddForms(1);
                }
            }
        }
    }
    #endregion
}
