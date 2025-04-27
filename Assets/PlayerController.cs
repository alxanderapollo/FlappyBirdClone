using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float flapForce = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * flapForce;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Something hit me!");
        // collsion with anything means destruction!
        Destroy(gameObject);
        // call function to bring up end game stuff
    }
}
