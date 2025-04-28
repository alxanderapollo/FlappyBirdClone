using UnityEngine;

public class mountain_ground_spawner : MonoBehaviour
{
    [SerializeField] private GameObject mountains;     // Mountain prefab to spawn
    [SerializeField] private float height_range = 0.45f;
    [SerializeField] private float max_time = 1.5f;    // Seconds between spawns
    [SerializeField] private float seconds_to_destroy = 15.5f;
    private float timer;
    private void Start()
    {
        RespawnPosition();
    }           // Internal timer

    void Update()
    {
        if (timer >= max_time)
        {
            RespawnPosition();
            timer = 0f;              // Reset timer
        }
        timer += Time.deltaTime;

    }

    void RespawnPosition()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-height_range, height_range));
        GameObject mount = Instantiate(mountains, spawnPosition, Quaternion.identity);
        Destroy(mount, seconds_to_destroy);
    }
}
