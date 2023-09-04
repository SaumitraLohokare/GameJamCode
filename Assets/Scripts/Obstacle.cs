using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // Adjust the speed as needed
    public float destroyXPosition = -12.0f; // Adjust the point where the obstacle should be destroyed

    // Update is called once per frame
    void Update()
    {
        // Move the obstacle to the left
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        // Check if the obstacle's x position is less than the destroyXPosition
        if (transform.position.x <= destroyXPosition)
        {
            // Destroy the obstacle GameObject
            Destroy(gameObject);
        }
    }
}
