using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //--------------------------------------------------//
    // Public parameters to be populated on the console //
    //--------------------------------------------------//

    // Referencing the player movement script/component:
    public PlayerMovement movement;


    //----------------//
    // Custom Methods //
    //----------------//

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Disable player movement script:
            movement.enabled = false;
            // Run GameOver function from GameManager object after colliding:
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
