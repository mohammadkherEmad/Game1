using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController Controller;
    public Transform Cam;
    public Animator ani;
    
    public float speed = 10f;

    

    void Update()
    {

        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(Horizontal, 0f , Vertical ).normalized;

        ani.SetFloat("Speed", direction.magnitude);


        if (direction.magnitude >= 0.1f )
        {
            float TargetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + Cam.eulerAngles.y ;
            transform.rotation = Quaternion.Euler(0f, TargetAngle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, TargetAngle, 0f) * Vector3.forward;
            Controller.Move(moveDir.normalized * speed * Time.deltaTime);
            
        
        }

    }
}
