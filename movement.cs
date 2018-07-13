using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {
        speed = 10.0f;
        rotationSpeed = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float vTranslation = Input.GetAxis("Vertical") * speed;
        float hTanslation = Input.GetAxis("Horizontal") * speed;
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed;
        // Make it move 10 meters per second instead of 10 meters per frame...
        vTranslation *= Time.deltaTime;
        hTanslation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        // Move translation along the object's z-axis
        transform.Translate(hTanslation, 0, vTranslation);
        transform.Rotate(0, rotation, 0);
    }
}
