using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //--------------------------------------------------//
    // Public parameters to be populated on the console //
    //--------------------------------------------------//

    // Player position:
    public Transform player;
    // Score text:
    public Text scoreText;



    //-----------------//
    // Update Function //
    //-----------------//

    void Update()
    {
        // Update text with player distance in meters as score:
        scoreText.text = player.position.z.ToString("0");
    }
}
