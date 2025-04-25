using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;     // Drag your pipe prefab here in the inspector
    public float spawnInterval = 2f;  // How often to spawn pipes
    public float minY = -1f;          // Min height for pipe gap
    public float maxY = 3f;           // Max height for pipe gap
    public float spawnX = 10f;        // X-position to spawn pipes

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 0f, spawnInterval);
    }

    void SpawnPipe()
    {
        float y = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, y, 0f);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}
