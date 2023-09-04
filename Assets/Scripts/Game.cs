using UnityEngine;

public class Game : MonoBehaviour
{
    private bool isActive = false;
    public bool IsActive {
        get { return isActive; }
    }

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize isActive based on whether the GameObject is active in the hierarchy
        isActive = gameObject.activeInHierarchy;
    }

    // Update is called once per frame
    void Update()
    {
        // Update isActive during runtime
        isActive = gameObject.activeInHierarchy;

        if (isActive)
        {
            // Perform game-related updates here
            
        }
    }

    public void ChangePath(GameObject pathButton) {
        player.MovePlayerTo(pathButton);
    }
}
