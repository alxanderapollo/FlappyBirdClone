using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 2f;
    private float groundWidth;

    void Start()
    {
        // Get width of the ground sprite
        groundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // If the ground moves too far left, reset its position to the right
        if (transform.position.x < -groundWidth)
        {
            transform.position += Vector3.right * groundWidth * 2f;
        }
    }
}