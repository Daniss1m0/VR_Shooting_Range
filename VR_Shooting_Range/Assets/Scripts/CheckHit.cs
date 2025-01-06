using UnityEngine;

public class CheckHit : MonoBehaviour
{
    private HitManager hitManager;

    private void Start()
    {
        hitManager = FindObjectOfType<HitManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FallingObject"))
        {
            hitManager.IncreaseHitCount();
            //Destroy(collision.gameObject);
        }
    }

}
