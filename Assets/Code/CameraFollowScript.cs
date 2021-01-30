using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{

    public Transform _player;
    [SerializeField]
    private float xCameraOffset;
    [SerializeField]
    private float yCameraOffset;
    [SerializeField]
    private float zCameraOffset;
    [SerializeField]
    private float xPositionCameraOffset;
    [SerializeField]
    private float yPositionCameraOffset;
    [SerializeField]
    private float zPositionCameraOffset;


    void Start()
    {
        LookAtPlayer();
        FollowPlayer();
    }

    void LookAtPlayer()
    {
        this.gameObject.transform.LookAt(new Vector3(_player.position.x + xCameraOffset, _player.position.y + yCameraOffset, _player.position.z + zCameraOffset));
    }

    void FollowPlayer()
    {
        this.gameObject.transform.position=new Vector3(_player.position.x + xPositionCameraOffset, _player.position.y + yPositionCameraOffset, _player.position.z + zPositionCameraOffset);


    }

}
