using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public GGJInput controls;
    [SerializeField] private float speed; 
    private void Awake()
    {
        controls = new GGJInput();
        controls.Player.Hit.performed += h => Hit();
    }


    void Update()
    {

        var move = controls.Player.Movement.ReadValue<Vector2>();
        Move(move);
        var rotate = controls.Player.Rotation.ReadValue<Vector2>();
        Rotate(rotate);
    }

    void Rotate(Vector2 x)
    {
        Debug.Log("Rotate Player " + x);
    }

    void Move(Vector2 v)
    {
        Debug.Log("Move Player " + v);
        
        this.transform.Translate(new Vector3(v.x / speed, 0,v.y /speed));
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
