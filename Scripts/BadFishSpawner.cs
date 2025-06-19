using UnityEngine;

public class BadFishSpawner : MonoBehaviour
{
    public GameObject badFishPrefab;
    public float spawnInterval = 5f;      // Ќачальный интервал спауна злой рыбы
    public int spawnCount = 2;            //  ол-во за спаун
    public float accelerationTime = 30f;  // ¬рем€ дл€ максимального ускорени€
    private float timer = 0f;
    private float elapsed = 0f;

    void Update()
    {
        elapsed += Time.deltaTime;
        timer += Time.deltaTime;

        float t = Mathf.Clamp01(elapsed / accelerationTime);

        float currentInterval = Mathf.Lerp(spawnInterval, 1f, t);  // уменьшаем интервал до 1 секунды
        int currentSpawnCount = Mathf.FloorToInt(Mathf.Lerp(spawnCount, 3, t)); // увеличиваем кол-во до 3

        if (timer >= currentInterval)
        {
            timer = 0f;

            for (int i = 0; i < currentSpawnCount; i++)
            {
                Vector3 spawnPos = new Vector3(10, Random.Range(-4f, 4f), 0);
                Instantiate(badFishPrefab, spawnPos, Quaternion.identity);
            }
        }
    }
}
