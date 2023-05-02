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

          //  rb.velocity = new Vector2(Speed.x,Speed.y);

    }


    private void Update()
    {           

             

          rb.velocity =new Vector2(Speed.x,Speed.y);
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

        if (col.transform.CompareTag("Wall"))
        {
                   Speed.y*=-1f;     
                
        }else{
                Debug.Log(col.collider.transform.name);
                 //Speed.y = 0.5f;
                Speed.y = Random.Range(-1f,1f);
                Speed.x *= -1f;
                 //  Debug.Log(rb.velocity);        
        }
 

    }

    // cuando no es trigger

    private void OnTriggerEnter2D(Collider2D collider){
                Debug.Log("GOL!");  
                transform.position= new Vector3(0f,0f,0f);

    }
 




}
