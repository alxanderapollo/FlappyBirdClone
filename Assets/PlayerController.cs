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
        Debug.Log("Something hit me!");
        // collsion with anything means destruction!
        Destroy(gameObject);
        // call function to bring up end game stuff
        Debug.Log("Final Score: " + Score.score);
    }
}
