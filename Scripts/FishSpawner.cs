using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public float spawnInterval = 3f;      // Начальный интервал между спаунами
    public int spawnCount = 1;             // Сколько рыб спаунится за раз
    public float accelerationTime = 30f;  // Время за которое увеличивается сложность
    private float timer = 0f;
    private float elapsed = 0f;

    void Update()
    {
        elapsed += Time.deltaTime;
        timer += Time.deltaTime;

        // Уменьшаем интервал и увеличиваем количество рыб по времени
        float t = Mathf.Clamp01(elapsed / accelerationTime);

        float currentInterval = Mathf.Lerp(spawnInterval, 0.5f, t);  // уменьшаем интервал до 0.5 сек
        int currentSpawnCount = Mathf.FloorToInt(Mathf.Lerp(spawnCount, 5, t)); // увеличиваем число до 5 рыб

        if (timer >= currentInterval)
        {
            timer = 0f;

            for (int i = 0; i < currentSpawnCount; i++)
            {
                Vector3 spawnPos = new Vector3(10, Random.Range(-4f, 4f), 0);
                Instantiate(fishPrefab, spawnPos, Quaternion.identity);
            }
        }
    }
}
