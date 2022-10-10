using UnityEngine;

public class Credits : MonoBehaviour
{
    //------------------//
    // Custom Functions //
    //------------------//

    public void QuitGame()
    {
        // Show message inside Unity:
        Debug.Log("QUIT");
        // Shut down aplication - works only after exporting:
        Application.Quit();
    }
}
