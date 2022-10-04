using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {


        var horizontalMove = Input.GetAxis("Horizontal") * speed ;

        //Character Speed
        _rb.velocity = new Vector3(horizontalMove, 0,speed ) ;
    }
}
