using UnityEngine;

public class FishMover : MonoBehaviour
{
    public float speed = 3f;

    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            sr.flipX = true;  // ���� ������� ����� ������
        }
    }

    void Update()
    {
        // �������� �����
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // ����������, ���� ����� �� ����� ����
        if (transform.position.x < -10f)
            Destroy(gameObject);
    }
}
