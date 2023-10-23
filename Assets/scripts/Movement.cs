using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //variables

    [SerializeField] private float speed = 10f;
    private float horizontalInput;
    [SerializeField] private float lateralspeed = 20f;
    private float verticalInput;

    // variable camara

    [SerializeField] private GameObject camera;
    [SerializeField] private Vector3 offset;
    

    //funciones

    // Update
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(translation: new Vector3(0, 0, 1) * speed * Time.deltaTime * verticalInput);

        horizontalInput = Input.GetAxis("Horizontal");

        camera.transform.position = transform.position + offset;

        if (verticalInput>0 || verticalInput<0)
        {
            transform.Rotate(Vector3.up * lateralspeed * Time.deltaTime * horizontalInput);
        }

        //transform.Translate(Vector3.right * lateralspeed * Time.deltaTime * horizontalInput);
    }
}
