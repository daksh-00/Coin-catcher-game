
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float fallSpeed = 4f;

    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.LoseLife();
            Destroy(gameObject);
        }
    }
}
