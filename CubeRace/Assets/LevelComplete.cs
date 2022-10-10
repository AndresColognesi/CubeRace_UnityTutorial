using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    //------------------//
    // Custom Functions //
    //------------------//

    public void LoadNextLevel()
    {
        // Load the next scene based on the build index number:
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
