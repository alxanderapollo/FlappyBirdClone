using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float flyForce = 6f;
    [SerializeField] private float _rotationSpeed = 10f;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip crashSound;
    [SerializeField] private AudioClip jumpSound;
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
            audioSource.PlayOneShot(jumpSound, 0.15f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(crashSound);
        // Destroy(gameObject);
        Time.timeScale = 0;
        GameOverManager gameOverManager = FindObjectOfType<GameOverManager>();
        gameOverManager.ShowGameOver();  // Trigger the GameOver screen
        AudioSource engineHum = FindObjectOfType<AudioSource>();
        engineHum.Stop();
        GetComponent<SpriteRenderer>().enabled = false;   // Hide sprite
        GetComponent<Collider2D>().enabled = false;       // Stop collisions
        rb.simulated = false;
    }
}
