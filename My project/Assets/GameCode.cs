using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCode : MonoBehaviour
{
    public UnityEvent OnCollision;
    public GameObject myStar;
    public GameObject myDartBoard;
    
    public float forceMagnitude = 10f; // The force to apply to the object
    private Rigidbody rb; // The object's Rigidbody component
    private Camera cam; // The main camera in the scene
    private Vector3 forceDirection;




    public Color newColor;
    public float newEmission = 1f;

    

    private void OnCollisionEnter(Collision collision) {

    if (collision.gameObject == myDartBoard) // Check if the collision was with the myDartBoard object
        {
        OnCollision.Invoke();
        Renderer starRenderer = myStar.GetComponent<Renderer>(); // Get the Renderer component of the myStar object
        Material starMaterial = starRenderer.material; // Get the material of the Renderer component
        starMaterial.color = newColor; // Set the new color for the material
        starMaterial.SetColor("_EmissionColor", new Color(newEmission, newEmission, newEmission)); // Set the new emission for the material
        }
    }

    public GameObject myball;

    private void Start()
    {
        rb = myball.GetComponent<Rigidbody>(); // Get the Rigidbody component when the script starts
        //cam = Camera.main; // Get the main camera in the scene
        forceDirection = Vector3.right;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Check if the spacebar is currently pressed
        {
             rb.AddForce(forceDirection * forceMagnitude, ForceMode.Force);
            // Apply the force to the object's Rigidbody
        }
    }
}
