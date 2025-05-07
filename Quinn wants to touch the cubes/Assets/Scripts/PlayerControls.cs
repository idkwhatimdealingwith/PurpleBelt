using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    [Header("Rigidbody")]
    //Rigidbody component 
    public Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        //variable rb equals to
        //component rigidbody
        rb = GetComponent<Rigidbody>();
        //Game is at normal:
        Time.timeScale = 1f; 
    }

    // Update is called once per frame
    void Update()
    {
        // Rotating the game object on the z-axis
        // multiplied by the game frame rate by 7
        transform.rotation *= Quaternion.Euler(0, 0, 7 * Time.deltaTime);

        // Time scale of the game plus
        // physics and other fixed frame rate updates 
        Time.timeScale += Time.fixedDeltaTime * 0.01f;

        // Movement and rotation of the camera 
        // on the y-axis horizontally 
        rb.velocity += transform.rotation * (Vector3.up * Input.GetAxisRaw("Horizontal") * 10f * Time.deltaTime);

        // Movement and rotation of the camera 
        // on the y-axis vertically 
        rb.velocity += transform.rotation * (Vector3.up * Input.GetAxisRaw("Vertical") * 10f * Time.deltaTime);

        // keeping the camera position in bounds 
        // Refactor the clamping into separate variables for clarity 
        float clampedX = Mathf.Clamp(transform.position.x, -30f, 30f);
        float clampedZ = Mathf.Clamp(transform.position.x, -30f, 30f);

        // Apply the clamped values to the transform's position 
        transform.position = new Vector3(clampedX, 0, clampedZ);
    }
}
