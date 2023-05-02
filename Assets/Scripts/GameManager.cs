using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
   public TextMeshProUGUI TextScore1;

   public TextMeshProUGUI TextScore2;

   public BallMovement ball;

   public PaddleMovement paddle1;
   
   public PaddleMovement paddle2;


   private void Start()
   {
        ball.OnGoal += OnGoalDelegate;
         StartGame();
    
   }

   private void Update(){

         if ( Input.GetKeyDown(KeyCode.Space)){
          Debug.Log ("ENTER");
               StartGame();

         }
          
   }



   private void OnGoalDelegate(object sender , EventArgs e){

        Debug.Log ("GameManager GOOOOOOL");

        OnGoalArgs args = e as OnGoalArgs;

        if(args.jugador == TipoJugador.JUG1){
             
             
             int puntaje = int.Parse(TextScore1.text);
             TextScore1.text = (puntaje +1).ToString();



        }else{

            int puntaje = int.Parse(TextScore2.text);
             TextScore2.text = (puntaje+1).ToString();
             

        }

        
      StopGame();

   }

   private void StartGame(){
        ball.Run();
        paddle1.Run();
        paddle2.Run();
   }     

   
   private void StopGame(){
        ball.Stop();
        paddle1.Stop();
        paddle2.Stop();
     
   }

}
