using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBounds : MonoBehaviour
{
    #region Serialize Fields
    [SerializeField] BoxCollider col;
    #endregion

    #region Public
    public static TargetBounds Instance;
    #endregion

    private void Awake() 
    {
        Instance = this;
    }

    #region API
    public Vector3 GetPosition()
    {
        Vector3 center = col.center + transform.position;

        float minX = center.x - col.size.x / 2f;
        float maxX = center.x + col.size.x / 2f;

        float minY = center.y - col.size.y / 2f;
        float maxY = center.y + col.size.y / 2f;

        float minZ = center.z - col.size.z / 2f;
        float maxZ = center.z + col.size.z / 2f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        Vector3 Position = new Vector3(randomX, randomY, randomZ);

        return Position;
    }
    #endregion
}
