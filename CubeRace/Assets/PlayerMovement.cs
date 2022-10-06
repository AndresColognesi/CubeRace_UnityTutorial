using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //--------------------------------------------------//
    // Public parameters to be populated on the console //
    //--------------------------------------------------//

    // Player rigid body:
    public Rigidbody rb;

    // Tunable physics parameters:
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


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
            rb.AddForce(sidewaysForce + Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce + Time.deltaTime, 0, 0);
        }
    }
}
