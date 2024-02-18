using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentController : MonoBehaviour
{

    //Variables

    [SerializeField] private float forwardSpeed;
    [SerializeField] private float rotateSpeed;
    private float verticalInput;
    private float verticalNegativeInput;
    private float horizontalInput;
    



    private void Update()
    {
        // if (Input.GetAxis("Acelerate"))

        

        verticalInput = Input.GetAxis("Acelerate");
        verticalNegativeInput = Input.GetAxis("Frenar");
        horizontalInput = Input.GetAxis("Rotate");

        if (verticalInput<0)
        {
            verticalInput = 0;
        }

        if (verticalNegativeInput > 0)
        {
            verticalNegativeInput= 0;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed * verticalNegativeInput);
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed * verticalInput);
        

        if (verticalInput > 0 || verticalNegativeInput < 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horizontalInput);
        }

    }
}
