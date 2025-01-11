using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float moveDistance = 0.5f;
    public float speed = 1.0f;

    private Vector3 startPosition;
    private bool canMove = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (canMove)
        {
            float offset = Mathf.PingPong(Time.time * speed, moveDistance);

            transform.position = new Vector3(startPosition.x + offset, startPosition.y, startPosition.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            canMove = false;
        }
    }
}
