using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float baseSpeed = 2f;        // начальная скорость
    public float acceleration = 0.1f;   // скорость прироста в секунду
    private float currentSpeed;

    void Start()
    {
        currentSpeed = baseSpeed;
    }

    void Update()
    {
        // Увеличиваем скорость со временем
        currentSpeed += acceleration * Time.deltaTime;

        // Двигаем рыбу влево с текущей скоростью
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
    }
}
