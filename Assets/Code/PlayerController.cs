using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public GGJInput controls;

    private void Awake()
    {
        controls = new GGJInput();
        controls.Player.Rotation.performed += _ => Rotate(_.ReadValue<Vector2>());
        controls.Player.Hit.performed += h => Hit();
    }


    void Update()
    {
        //var move = controls.Player.Movement.ReadValue<Vector2>();
        //Move(move);
    }

    void Rotate(Vector2 v)
    {
        Debug.Log("MovePlayer " + v );
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
