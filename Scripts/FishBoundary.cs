using UnityEngine;

public class FishBoundary : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fish"))
        {
            GameManager.instance.AddScore(-5);
            Debug.Log("⛔ Рыба уплыла! Минус 5 очков!");
            Destroy(other.gameObject);
        }
    }
}
