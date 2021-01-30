using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public GGJInput controls;
    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float rotationSpeed = 10f;


    private void Awake()
    {
        controls = new GGJInput();
        controls.Player.Hit.performed += h => Hit();
    }


    void Update()
    {

        var move = controls.Player.Movement.ReadValue<Vector2>();
        Move(move);
    }

    void Move(Vector2 v)
    {
            this.transform.Translate(new Vector3(v.x / movementSpeed, 0, v.y / movementSpeed));
            this.transform.Rotate(Vector3.up * v.x * rotationSpeed * Time.deltaTime);
    }


    void Hit()
    {
        Debug.Log("Hit");
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
