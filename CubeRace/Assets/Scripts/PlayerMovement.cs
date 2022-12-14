using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //--------------------------------------------------//
    // Public parameters to be populated on the console //
    //--------------------------------------------------//

    // Player rigid body:
    public Rigidbody rb;

    // Tunable physics parameters:
    public float forwardForce = 3500f;
    public float sidewaysForce = 1f;


    //-----------------//
    // Update Function //
    //-----------------//

    // Using Fixed update because we are using the Unity Physics system!
    void FixedUpdate() 
    {
        // Add constant force on the z-axis to move player forward:
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Player movement triggered by user input:
        if (Input.GetKey("d"))
        {
            // Add a lateral force that disconsideres object mass (dynamic system of order 1):
            rb.AddForce(sidewaysForce + Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        else if (Input.GetKey("a"))
        {
            // Add a lateral force that disconsideres object mass (dynamic system of order 1):
            rb.AddForce(-sidewaysForce + Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Handle end of game if player drops the platform:
        if (rb.position.y < -1f)
        {
            // Call GameOver method from Game Manager object:
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
