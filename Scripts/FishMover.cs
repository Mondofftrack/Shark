using UnityEngine;

public class FishMover : MonoBehaviour
{
    public float speed = 3f;

    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            sr.flipX = true;  // рыба смотрит влево всегда
        }
    }

    void Update()
    {
        // ƒвижение влево
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // ”ничтожить, если вышла за левый край
        if (transform.position.x < -10f)
            Destroy(gameObject);
    }
}
