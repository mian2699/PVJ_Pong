using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public TextMeshProUGUI TextScore1;

   public TextMeshProUGUI TextScore2;

   public BallMovement ball;

   public PaddleMovement paddle1;
   
   public PaddleMovement paddle2;

   public IABot iagame;

   public bool IAJUG;

   private string currentSceneName2;

   private void Start()
   {
        ball.OnGoal += OnGoalDelegate;
         StartGame();
    
   }



   private void Update(){
          

         if ( Input.GetKeyDown(KeyCode.Space) ){
                 Debug.Log ("ENTER");
               StartGame();

         }

       string currentSceneName2 = SceneManager.GetActiveScene().name;
          //Right Control key. LeftControl Left Control key.
          if ( Input.GetKeyDown(KeyCode.LeftControl) &&  currentSceneName2 == "J1vsIA" ){

                       //   Debug.Log ("ctrl1");
                           
               SceneManager.LoadScene("J1vsJ2");
                         //  J1vsJ2();


         }else if( Input.GetKeyDown(KeyCode.LeftControl) &&  currentSceneName2 == "J1vsJ2"){
                     //     Debug.Log ("ctrl2");
                   SceneManager.LoadScene("J1vsIA");
                       //   J1vsIA();
         }
          
   }

      public void J1vsJ2(){
             

                  SceneManager.LoadScene("J1vsJ2");
     }

     public void J1vsIA(){
             SceneManager.LoadScene("J1vsIA");   
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
  
     
               ball?.Run();
               paddle1?.Run();
               paddle2?.Run();
               iagame?.Run();
         


   }     

   
   private void StopGame(){
       /* ball.Stop();
        paddle1.Stop();
        paddle2.Stop();*/

        if(IAJUG){

           ball?.Stop();
           iagame?.Stop();
           paddle1?.Stop();
           
        }else{

            ball?.Stop();
            paddle1?.Stop();
            paddle2?.Stop();
        }
     
   }

}
