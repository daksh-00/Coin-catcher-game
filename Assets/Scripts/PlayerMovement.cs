
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * move * speed * Time.deltaTime);

        float screenHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;

        float playerHalfWidth = GetComponent<SpriteRenderer>().bounds.extents.x;

        float clampedX = Mathf.Clamp(
            transform.position.x,
            -screenHalfWidth + playerHalfWidth,
            screenHalfWidth - playerHalfWidth
        );

        transform.position = new Vector3(
            clampedX,
            transform.position.y,
            transform.position.z
        );
    }
}
