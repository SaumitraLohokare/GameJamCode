using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Assign your obstacle prefab in the Inspector
    public Transform[] spawnPoints;   // Create an empty GameObject for each spawn point in the Inspector
    public float spawnInterval = 2.0f; // Adjust the interval between spawns as needed

    private float timeLeftForNextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize timeLeftForNextSpawn to the initial spawn interval
        timeLeftForNextSpawn = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // Reduce timeLeftForNextSpawn by the time elapsed since the last frame
        timeLeftForNextSpawn -= Time.deltaTime;

        // Check if it's time to spawn a new obstacle
        if (timeLeftForNextSpawn <= 0)
        {
            // Choose a random spawn point index (0, 1, or 2)
            int randomSpawnIndex = Random.Range(0, spawnPoints.Length);

            // Get the chosen spawn point's position
            Vector3 spawnPosition = spawnPoints[randomSpawnIndex].position;

            // Spawn the obstacle at the chosen position
            GameObject newObstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.Euler(0, 0, 90));
            newObstacle.transform.parent = gameObject.transform.parent.transform; // Set the parent

            // Update timeLeftForNextSpawn for the next spawn
            timeLeftForNextSpawn = spawnInterval;
        }
    }
}
