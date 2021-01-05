using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    // Start is called before the first frame update

public int rotationOffset = 0;
//public Transform transform;
        Vector3 MousePos;
    // Update is called once per frame
    void Update()
    {
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //MousePos.Normalize();
        if(Input.GetButtonDown("Fire1")){
            Shoot(); 
        }
        
    }
    private void FixedUpdate(){
        Vector2 lookDir = MousePos-transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x)*Mathf.Rad2Deg ;
        transform.rotation =  Quaternion.Euler (0f, 0f, angle);
        //transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0f, 0f, angle + rotationOffset), 200 * Time.deltaTime);
     }
    void Shoot(){

    }
}
