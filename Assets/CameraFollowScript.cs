using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{

    public Transform _player;
    [SerializeField]
    private int xCameraOffset;
    [SerializeField]
    private int yCameraOffset;
    [SerializeField]
    private int zCameraOffset;
    [SerializeField]
    private int xPositionCameraOffset;
    [SerializeField]
    private int yPositionCameraOffset;
    [SerializeField]
    private int zPositionCameraOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        FollowPlayer();
    }
    void LookAtPlayer()
    {
        this.gameObject.transform.LookAt(new Vector3(_player.position.x + xCameraOffset, _player.position.y+yCameraOffset, _player.position.z+zCameraOffset));
    }
    void FollowPlayer()
    {
        this.gameObject.transform.position=new Vector3(_player.position.x + xPositionCameraOffset, _player.position.y + yPositionCameraOffset, _player.position.z + zPositionCameraOffset);

    }
}
