using UnityEngine;

public class TestHit : MonoBehaviour
{
    private Rigidbody rb;
    private float lastYPosition;
    private bool isHit = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastYPosition = transform.position.y;
    }

    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Collision detected with: " + other.gameObject.name);

        if (other.gameObject.CompareTag("Bullet") && !isHit)
        {
            //Debug.Log("Current Y position: " + transform.position.y);
            HitManager hitManager = FindObjectOfType<HitManager>();

            if (transform.position.y < lastYPosition)
            {
                //Debug.Log("Hit while falling!");
                hitManager.IncreaseHitCount();
                isHit = true;
            }
            else
            {
                //Debug.Log("Not falling, so no hit counted.");
            }

            lastYPosition = transform.position.y;
        }
    }
}
