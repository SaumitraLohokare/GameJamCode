using UnityEngine;
using UnityEngine.UI;

public class ScreenSwitcher : MonoBehaviour
{
    public GameObject staticScreen;
    public GameObject gameScreen;
    public Button switchButton;
    public bool isStaticScreenActive = true;

    private void Start()
    {
        // Initialize the screen visibility and y positions
        ShowStaticScreen();

        // Attach the button click event to the ToggleScreens method
        switchButton.onClick.AddListener(ToggleScreens);
    }

    private void ToggleScreens()
    {
        // Toggle the visibility of the screens
        isStaticScreenActive = !isStaticScreenActive;
        // staticScreen.SetActive(isStaticScreenActive);
        // gameScreen.SetActive(!isStaticScreenActive);

        // Toggle the y position based on the active state
        float staticScreenZ = isStaticScreenActive ? -0.6f : -0.1f;
        staticScreen.transform.position = new Vector3(0f, 0f, staticScreenZ);
    }

    private void ShowStaticScreen()
    {
        // Show the static screen and set its initial y position
        // staticScreen.SetActive(true);
        staticScreen.transform.position = new Vector3(0f, 0f, -0.6f);
        // gameScreen.SetActive(false);
    }
}
