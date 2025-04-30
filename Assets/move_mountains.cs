using UnityEngine;

public class move_mountains : MonoBehaviour
{

    [SerializeField] private float speed = 0.65f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        int difficultyLevel = Score.score / 10;
        float currentSpeed = speed * Mathf.Pow(2, difficultyLevel);

        // Optional clamp to prevent going too fast
        currentSpeed = Mathf.Min(currentSpeed, 20f);

        transform.position += Vector3.left * currentSpeed * Time.deltaTime;
    }
}
