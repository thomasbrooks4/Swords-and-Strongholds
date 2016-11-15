using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
   public const int PIECE_AMOUNT = 4;
   public Hand hand;
   public Piece[] pieces;
}

public class HumanPlayer : Player {
   void Start() {
      hand = new Hand();
      pieces = new PlayerPiece[PIECE_AMOUNT];

      for (int i = 0; i < PIECE_AMOUNT; i++)
         pieces[i] = new PlayerPiece();
   }

   void Update() {

   }
}

public class AIPlayer : Player {
   void Start() {
      hand = new Hand();
      pieces = new EnemyPiece[PIECE_AMOUNT];

      for (int i = 0; i < PIECE_AMOUNT; i++)
         pieces[i] = new EnemyPiece();
   }

   void Update() {

   }
}