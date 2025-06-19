using UnityEngine;
using UnityEngine.UI; // Если будешь отображать здоровье в UI

public class SharkHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    // Опционально: ссылка на UI-текст для отображения здоровья
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
        Debug.Log("Акула погибла!");
        // Здесь можно добавить логику окончания игры, перезагрузки сцены и т.п.
        // Например:
        // UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
    }
}

