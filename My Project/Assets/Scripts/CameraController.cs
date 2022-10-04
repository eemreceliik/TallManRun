using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offSet;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        var position = player.transform.position;

        _camera.transform.position = new Vector3(position.x+offSet.x, position.y + offSet.y, position.z - offSet.z);
        
    }
}
