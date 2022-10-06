using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //--------------------------------------------------//
    // Public parameters to be populated on the console //
    //--------------------------------------------------//

    // Player transform:
    public Transform player;

    // Camera offset:
    public Vector3 offset;



    //-----------------//
    // Update Function //
    //-----------------//

    // Update is called once per frame
    void Update()
    {
        // Change position of camera:
        transform.position = player.position + offset; // lower case transform gets Transform from object were this script is hosted 
    }
}
