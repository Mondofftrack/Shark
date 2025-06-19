using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public float spawnInterval = 3f;      // ��������� �������� ����� ��������
    public int spawnCount = 1;             // ������� ��� ��������� �� ���
    public float accelerationTime = 30f;  // ����� �� ������� ������������� ���������
    private float timer = 0f;
    private float elapsed = 0f;

    void Update()
    {
        elapsed += Time.deltaTime;
        timer += Time.deltaTime;

        // ��������� �������� � ����������� ���������� ��� �� �������
        float t = Mathf.Clamp01(elapsed / accelerationTime);

        float currentInterval = Mathf.Lerp(spawnInterval, 0.5f, t);  // ��������� �������� �� 0.5 ���
        int currentSpawnCount = Mathf.FloorToInt(Mathf.Lerp(spawnCount, 5, t)); // ����������� ����� �� 5 ���

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
