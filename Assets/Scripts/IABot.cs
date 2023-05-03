using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IABot : MonoBehaviour
{
    public float Speed = 3;
    
    public BallMovement ball;

    private Vector2 ballPos;
    private bool running = false;

    private void Update(){
        
            Debug.Log(running);

           if (running){

            MovBall();
           }else{

              transform.position =new Vector3( transform.position.x,0f,0f);
           }



    }

    private void MovBall (){

            ballPos = ball.transform.position;


            
            if (transform.position.y > ballPos.y)
            {  
                

                        //transform.position += new Vector3(0f,-Speed*Time.deltaTime,0f);
                         //float movVertical = transform.x;

                          transform.position = new Vector3(
                        transform.position.x,
                        Mathf.Clamp(
                            transform.position.y +  -Speed * Time.deltaTime,
                            -4f,
                            4f
                        ),
                        transform.position.z);

                 

            }

            if (transform.position.y < ballPos.y)
            {
                     //transform.position += new Vector3(0f,Speed*Time.deltaTime,0f);
                     //float movVertical = 1f;

                      transform.position = new Vector3(
                        transform.position.x,
                        Mathf.Clamp(
                            transform.position.y + Speed * Time.deltaTime,
                            -4f,
                            4f
                        ),
                        transform.position.z);
            }



    }

      public void Run(){

            running = true;
    }


    public void Stop(){

            running = false;
    }
         

   
         




}
