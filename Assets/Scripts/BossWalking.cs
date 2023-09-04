using UnityEngine;

public class BossWalking : MonoBehaviour
{
    public GameObject[] WalkPoints;
    public GameObject Boss;
    public float movementSpeed = 0.002f; // Adjust this speed as needed
    private int currentWalkPointIndex;

    // Start is called before the first frame update
    void Start()
    {
        // Set the boss position to one of the walk points
        currentWalkPointIndex = Random.Range(0, WalkPoints.Length);
        Boss.transform.position = WalkPoints[currentWalkPointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the direction and distance to the current walk point
        Vector3 direction = (WalkPoints[currentWalkPointIndex].transform.position - Boss.transform.position).normalized;
        float distance = Vector3.Distance(Boss.transform.position, WalkPoints[currentWalkPointIndex].transform.position);

        // Check if the boss has reached the current walk point
        if (distance <= movementSpeed)
        {
            // Set the boss's position to the current walk point
            Boss.transform.position = WalkPoints[currentWalkPointIndex].transform.position;

            // Pick a random adjacent walk point
            int randomAdjacentIndex = Random.Range(0, WalkPoints[currentWalkPointIndex].GetComponent<Walkpoint>().Adjacents.Length);
            GameObject randomAdjacentPoint = WalkPoints[currentWalkPointIndex].GetComponent<Walkpoint>().Adjacents[randomAdjacentIndex];

            // Update the current walk point index
            currentWalkPointIndex = System.Array.IndexOf(WalkPoints, randomAdjacentPoint);
        }
        else
        {
            // Move the boss towards the current walk point
            Boss.transform.position += direction * movementSpeed;
        }
    }
}
