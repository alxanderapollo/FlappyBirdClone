using UnityEngine;

public class move_mountains : MonoBehaviour
{

    [SerializeField] private float speed = 0.65f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
