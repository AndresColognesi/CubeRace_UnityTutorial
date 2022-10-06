using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public parameters to be populated on the console:
    public Rigidbody rb;


    // Using Fixed update because we are using the Unity Physics system!
    void FixedUpdate() 
    {
        // Add constant force on the z-axis to move player forward:
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
