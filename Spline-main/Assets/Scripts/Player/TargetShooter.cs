using UnityEngine;
using Unity;
using System.Collections;
using System.Collections.Generic;

public class TargetShooter : MonoBehaviour
{
    #region Serialize Fields
    [SerializeField] Camera cam;

    [SerializeField] public ParticleSystem ParticleSystem;

    [SerializeField] public AudioSource GunSound;
    #endregion

    #region API
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GunSound.Stop();
            GunSound.Play();
            ParticleSystem.Play();


            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();

                if(target != null)
                {
                    Destroy(target.gameObject);
                    Inventory.instance.AddForms(1);
                }
            }
        }
    }
    #endregion
}
