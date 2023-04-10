using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private new Rigidbody rigidbody;
    public float moveSpeed = 5f;
    
    private Transform mainCameraTransform;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        mainCameraTransform = Camera.main.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        {

            // Obtener los valores de entrada del teclado para el eje horizontal y vertical
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            

            // Obtener la direcci�n de movimiento basada en la c�mara del jugador
            Vector3 forward = mainCameraTransform.forward;
            Vector3 right = mainCameraTransform.right;
            forward.y = 0f;
            right.y = 0f;
            forward.Normalize();
            right.Normalize();
            Vector3 direction = forward * verticalInput + right * horizontalInput;

            // Mover el personaje en la direcci�n calculada
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Asignar teclas personalizadas para el movimiento
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += -right * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += right * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += forward * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += -forward * moveSpeed * Time.deltaTime;
            }
           
        }


    }
}
