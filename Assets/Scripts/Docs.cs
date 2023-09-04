using UnityEngine;

public class Docs : MonoBehaviour
{
    private bool isActive = false;

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
            // Perform document-related updates here
            
        }
    }
}
