using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] Paths;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to change the x position of the player
    public void MovePlayerTo(GameObject targetObject)
    {
        if (targetObject != null)
        {
            // Get the target x position
            float targetY = targetObject.transform.position.y;

            // Update the player's position
            Vector3 newPosition = transform.position;
            newPosition.y = targetY;
            transform.position = newPosition;
        }
    }

    // Detect collisions with objects on the "Obstacles" layer
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
        if (collision.gameObject.layer == LayerMask.NameToLayer("Screens"))
        {
            // Handle game over logic (e.g., display a game over screen, restart the level, etc.)
            Debug.Log("GameOver");
        }
    }
}
