using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            score = score + 1;
        }
    }
}
