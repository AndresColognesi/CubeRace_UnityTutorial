using UnityEngine;
using UnityEngine.SceneManagement; //to operate on the scenes

public class GameManager : MonoBehaviour
{
    //--------------------------------------------------//
    // Public parameters to be populated on the console //
    //--------------------------------------------------//

    // Referencing the complete level panel:
    public GameObject completeLevelUI;



    //--------------------//
    // Private Attributes //
    //--------------------//

    // GameOver flag:
    bool gameHasEnded = false;



    //------------------//
    // Custom Functions //
    //------------------//

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

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

}