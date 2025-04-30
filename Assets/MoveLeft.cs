using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 2f;
    private float groundWidth;
    int difficultyIncrease;

    void Start()
    {
        // Get width of the ground sprite
        groundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Calculate difficulty level based on score
        int difficultyLevel = Score.score / 10;

        // Adjust speed by a power of 2 based on difficulty level
        float currentSpeed = speed * Mathf.Pow(2, difficultyLevel);

        // Move ground left based on current speed
        transform.position += Vector3.left * currentSpeed * Time.deltaTime;

        // Loop ground if it moves off screen
        if (transform.position.x < -groundWidth)
        {
            transform.position += Vector3.right * groundWidth * 2f;
        }
    }
}