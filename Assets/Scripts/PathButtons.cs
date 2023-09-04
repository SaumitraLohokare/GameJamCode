using UnityEngine;

public class PathButton : MonoBehaviour
{
    private Game gameScript;

    void Start() {
        gameScript = GetComponentInParent<Game>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        // Get a reference to the Game.cs script

        // Check if the gameScript is not null
        if (gameScript != null)
        {
            // Set the selected path number in the Game.cs script
            gameScript.ChangePath(gameObject);
        }
    }
}
