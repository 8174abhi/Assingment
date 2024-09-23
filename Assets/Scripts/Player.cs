using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 5f;
    [SerializeField] private float JumpSpeed = 10f;
    [SerializeField] private float RotateSpeed = 3f;
    public bool isJumping=false;
    public bool isMoving;
    public Vector3 Movedir;
    
    public static Player instance;
    private void Awake()
    {
        instance = this;
       
    }
    private void Update()
    {
        HandleMovement();
        Jumping();
       
    }
   private void HandleMovement()
    {
        
        Vector2 Inputvector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            Inputvector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Inputvector.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Inputvector.x = +1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Inputvector.x = -1;
        }
        Inputvector = Inputvector.normalized;
        
         Movedir=new Vector3(Inputvector.x,0,Inputvector.y);
        if (Movedir != Vector3.zero)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }


        transform.position += Movedir * MoveSpeed * Time.deltaTime;
        transform.forward=Vector3.Slerp(transform.forward, Movedir, RotateSpeed*Time.deltaTime);
      

    }
    void Jumping()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = true;
            transform.Translate(Vector3.up * JumpSpeed * Time.deltaTime);
        }
        else
        {
            isJumping = false;
        }
    }

}
