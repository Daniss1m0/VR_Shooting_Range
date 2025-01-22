using UnityEngine;
using UnityEngine.SceneManagement;

public class HitCounter : MonoBehaviour
{
    public static int TotalHits { get; private set; } = 0;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        TotalHits = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TotalHits++;
            Destroy(collision.gameObject);
        }
    }
}
