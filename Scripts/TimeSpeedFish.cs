using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float baseSpeed = 2f;        // ��������� ��������
    public float acceleration = 0.1f;   // �������� �������� � �������
    private float currentSpeed;

    void Start()
    {
        currentSpeed = baseSpeed;
    }

    void Update()
    {
        // ����������� �������� �� ��������
        currentSpeed += acceleration * Time.deltaTime;

        // ������� ���� ����� � ������� ���������
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
    }
}
