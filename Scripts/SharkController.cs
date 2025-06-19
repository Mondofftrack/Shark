using UnityEngine;
using UnityEngine.UI;

public class SharkController : MonoBehaviour
{
    public float speed = 5f;
    public int score = 0;
    public int lives = 3;
    public Text livesText;
    public Text scoreText;

    public MobileInput mobileInput; // 📱 Сюда перетащи MobileInputController

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateLivesUI();
        UpdateScoreUI();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // 👉 Управление через телефон
        if (mobileInput != null)
        {
            moveX = 0f;
            moveY = 0f;

            if (mobileInput.leftPressed) moveX = -1f;
            if (mobileInput.rightPressed) moveX = 1f;
            if (mobileInput.upPressed) moveY = 1f;
            if (mobileInput.downPressed) moveY = -1f;
        }

        Vector3 movement = new Vector3(moveX, moveY, 0).normalized;
        transform.position += movement * speed * Time.deltaTime;

        if (moveX > 0)
            spriteRenderer.flipX = false;
        else if (moveX < 0)
            spriteRenderer.flipX = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fish"))
        {
            Destroy(other.gameObject);
            score += 10;
            UpdateScoreUI();
        }
        else if (other.CompareTag("BadFish"))
        {
            Destroy(other.gameObject);
            lives--;
            score -= 50;
            UpdateLivesUI();
            UpdateScoreUI();

            if (lives <= 0)
            {
                Debug.Log("Game Over!");
                // TODO: сделать конец игры
            }
        }
    }

    void UpdateLivesUI()
    {
        if (livesText != null)
            livesText.text = "Lives: " + lives;
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
