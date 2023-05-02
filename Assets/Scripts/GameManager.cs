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
   
   public void Start()
   {
        ball.OnGoal += OnGoalDelegate;
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


   }
}
