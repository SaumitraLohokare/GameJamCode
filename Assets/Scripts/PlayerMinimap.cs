using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMinimap : MonoBehaviour
{
    public ScreenSwitcher screenSwitcher;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("GameOver");
        // Check if the collision is with a collider on the "Boss" layer and is a trigger
        if (other.gameObject.layer == LayerMask.NameToLayer("Boss") && other.isTrigger)
        {
            // Check the screenSwitcher's isStaticScreenActive flag
            if (!screenSwitcher.isStaticScreenActive)
            {
                // Trigger game over logic (you can replace this with your actual game over logic)
                Debug.Log("GameOver");
            }
        }
    }
}
