using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
       //Avanzar sin parar
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //Movimiento lateral
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        //Movimiento Vertical
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //rotación
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
