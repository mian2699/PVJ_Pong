using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    
    //public float Speed = 1f;

    public Vector3 Speed;// = new Vector2(1f,0f);
    private Rigidbody2D rb;

    private void Start(){
         
            rb =transform.GetComponent<Rigidbody2D>();

            rb.velocity = new Vector2(Speed.x,Speed.y);

    }


    private void Update()
    {
            //float movHorizontal = Input.GetAxis("Horizontal");

            
           /* Vector3 position = transform.position;

            Vector3  nuevaPosicion = new Vector3(

                    position.x + (Speed * Time.deltaTime),
                    position.y,
                    position.z
            );


            transform.position = nuevaPosicion;*/

          // vector3 rigth equivalente
          //Vector3 derechoUnitario = new Vector3(1f,0f,0f);

           /* transform.position +=  
                Vector3.right * Speed * Time.deltaTime;*/

    }

    private void OnCollisionEnter2D(Collision2D col){

            Speed *= -1;
           //Debug.Log("Colision");
    }
 




}
