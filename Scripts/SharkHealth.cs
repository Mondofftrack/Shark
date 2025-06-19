using UnityEngine;
using UnityEngine.UI; // ���� ������ ���������� �������� � UI

public class SharkHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    // �����������: ������ �� UI-����� ��� ����������� ��������
    public Text healthText;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;

        UpdateHealthUI();

        if (currentHealth == 0)
        {
            Die();
        }
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
            healthText.text = "Health: " + currentHealth;
    }

    void Die()
    {
        Debug.Log("����� �������!");
        // ����� ����� �������� ������ ��������� ����, ������������ ����� � �.�.
        // ��������:
        // UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
    }
}

