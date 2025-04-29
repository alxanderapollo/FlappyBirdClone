using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float flyForce = 5f;
    [SerializeField] private float _rotationSpeed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * _rotationSpeed);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * flyForce;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
        Time.timeScale = 0;
        GameOverManager gameOverManager = FindObjectOfType<GameOverManager>();
        gameOverManager.ShowGameOver();  // Trigger the GameOver screen
    }
}
