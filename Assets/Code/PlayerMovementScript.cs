using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody myBody;
    [SerializeField]
    private bool isGrounded;
    private Ray groundCheck;
    public Transform _rayPoint;
    [SerializeField]
    private int rayLength;
    

    void Start()
    {
        myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfGrounded();
        MovePlayer();
    }

    void MovePlayer()
    {
         
        if (isGrounded == true)
        {
            float _horiz = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
            float _vert = Input.GetAxisRaw("Vertical") * Time.deltaTime;
            

            myBody.MovePosition(new Vector3(_vert, _horiz, 0));
        }
    }

    void CheckIfGrounded()
    { 
        if (Physics.Raycast(_rayPoint.position,_rayPoint.TransformDirection(Vector3.down),rayLength))
        {
            if (CompareTag("Ground"))
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }

        }
       
    }
}
