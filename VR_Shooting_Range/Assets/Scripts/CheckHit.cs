using UnityEngine;
using System.Collections.Generic;

public class CheckHit : MonoBehaviour
{
    private HitManager hitManager;
    private HashSet<GameObject> hitObjects = new HashSet<GameObject>();

    private void Start()
    {
        hitManager = FindObjectOfType<HitManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FallingObject") && !hitObjects.Contains(collision.gameObject))
        {
            hitManager.IncreaseHitCount();
            hitObjects.Add(collision.gameObject);
            // Destroy(collision.gameObject);
        }
    }
}
