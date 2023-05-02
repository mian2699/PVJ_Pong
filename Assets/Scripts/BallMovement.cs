using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


enum TipoJugador{

        JUG1 ,JUG2
}
class OnGoalArgs : EventArgs {

        public TipoJugador jugador;
}
public class BallMovement : MonoBehaviour
{
    
    //public float Speed = 1f;
    public event EventHandler OnGoal;    
    public Vector3 Speed;// = new Vector2(1f,0f);
    private Rigidbody2D rb;
    private bool running = false;
    private void Start(){
         
            rb =transform.GetComponent<Rigidbody2D>();

          //  rb.velocity = new Vector2(Speed.x,Speed.y);

    }


    private void Update()
    {           

       if (running) {rb.velocity =new Vector2(Speed.x,Speed.y);
       
       
       
       }else{

                rb.velocity =  Vector2.zero;
       }
          
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
                Speed.y = UnityEngine.Random.Range(-1f,1f);
                Speed.x *= -1f;
                 //  Debug.Log(rb.velocity);        
        }
 

    }

    // cuando no es trigger

    private void OnTriggerEnter2D(Collider2D collider){
                Debug.Log("GOL!");  
                OnGoalArgs args = new OnGoalArgs();

                if ( rb.velocity.x < 0){
                        args.jugador = TipoJugador.JUG2;
                }else{
                        args.jugador = TipoJugador.JUG1;
                }
                
                OnGoal?.Invoke(this,args);
                transform.position= new Vector3(0f,0f,0f);

    }

     public void Run(){

            running = true;
    }


    public void Stop(){

            running = false;
    }

 




}
