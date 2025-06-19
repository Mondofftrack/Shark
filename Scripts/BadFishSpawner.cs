using UnityEngine;

public class BadFishSpawner : MonoBehaviour
{
    public GameObject badFishPrefab;
    public float spawnInterval = 5f;      // ��������� �������� ������ ���� ����
    public int spawnCount = 2;            // ���-�� �� �����
    public float accelerationTime = 30f;  // ����� ��� ������������� ���������
    private float timer = 0f;
    private float elapsed = 0f;

    void Update()
    {
        elapsed += Time.deltaTime;
        timer += Time.deltaTime;

        float t = Mathf.Clamp01(elapsed / accelerationTime);

        float currentInterval = Mathf.Lerp(spawnInterval, 1f, t);  // ��������� �������� �� 1 �������
        int currentSpawnCount = Mathf.FloorToInt(Mathf.Lerp(spawnCount, 3, t)); // ����������� ���-�� �� 3

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
