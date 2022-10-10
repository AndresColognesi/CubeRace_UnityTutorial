using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //------------------//
    // Custom Functions //
    //------------------//

    public void StartGame()
    {
        // Load next scene:
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
