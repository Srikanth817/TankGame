using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed;
    public float moveSpeed2;
    public Rigidbody2D rb;
    //public Camera cam;

    float dx;
    float dy;


    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        dx = Input.GetAxisRaw("Horizontal");
        dy = Input.GetAxisRaw("Vertical");
        //MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }

    private void FixedUpdate(){
        float angleV =-dx*moveSpeed;
        float velCom = dy*moveSpeed2;
        float xv = (float) Math.Cos(rb.rotation*(Math.PI/180));
        float yv = (float) Math.Sin(rb.rotation*(Math.PI/180));
        Vector2 movement = new Vector2(xv*dy*moveSpeed2,yv*dy*moveSpeed2);

        rb.angularVelocity = angleV;
        rb.velocity = movement;

       
        //Debug.Log("Angle: " + rb.rotation);
    }
}
