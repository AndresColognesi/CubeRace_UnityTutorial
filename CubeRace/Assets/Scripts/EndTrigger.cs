using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    //--------------------------------------------------//
    // Public parameters to be populated on the console //
    //--------------------------------------------------//

    // Referencing the GameManager object:
    public GameManager gameManager;


    //---------------------------------------------//
    // Custom Functions - Based on Unity Functions //
    //---------------------------------------------//

    private void OnTriggerEnter(Collider other)
    {
        // Call the CompleteLevel method form the GameManager:
        gameManager.CompleteLevel();
    }
}
