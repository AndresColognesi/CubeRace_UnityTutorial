using UnityEngine;
using UnityEngine.SceneManagement; //to operate on the scenes

public class GameManager : MonoBehaviour
{
    //--------------------//
    // Private Attributes //
    //--------------------//

    // GameOver flag:
    bool gameHasEnded = false;



    //------------------//
    // Custom Functions //
    //------------------//

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            // Show game over debug message:
            Debug.Log("GAME OVER!");
            // Set control boolean:
            gameHasEnded = true;
            // Restart level with delay:
            Invoke("Restart", 1f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}