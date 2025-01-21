using UnityEngine;
using System.Collections.Generic;

public class CheckShootDown : MonoBehaviour
{
    private ShootDownTheTargets shootdownTheTargetsManager;
    private HashSet<GameObject> hitObjects = new HashSet<GameObject>();

    private void Start()
    {
        shootdownTheTargetsManager = FindObjectOfType<ShootDownTheTargets>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FallingObject") && !hitObjects.Contains(collision.gameObject))
        {
            shootdownTheTargetsManager.IncreaseHitCount();
            hitObjects.Add(collision.gameObject);
            // Destroy(collision.gameObject);
        }
    }
}
