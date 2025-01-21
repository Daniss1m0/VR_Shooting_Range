using UnityEngine;

public class HitCounter : MonoBehaviour
{
    public static int TotalHits { get; private set; } = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TotalHits++;
            Destroy(collision.gameObject);
        }
    }
}
