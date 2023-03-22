using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeGamePhysics : MonoBehaviour
{
    public float forceMagnitude = 10f; // The force to apply to the object
    private Rigidbody rb; // The object's Rigidbody component
    private Camera cam; // The main camera in the scene

    public GameObject myball;

    private void Start()
    {
        rb = myball.GetComponent<Rigidbody>(); // Get the Rigidbody component when the script starts
        cam = Camera.main; // Get the main camera in the scene
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Check if the spacebar is currently pressed
        {
            Vector3 direction = cam.transform.position - transform.position;
            // Calculate the force direction
            rb.AddForce(direction.normalized * forceMagnitude, ForceMode.Impulse);
            // Apply the force to the object's Rigidbody
        }
    }
}
