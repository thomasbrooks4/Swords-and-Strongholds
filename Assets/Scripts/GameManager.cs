using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	const int HAND_AMOUNT = 3;

	Board board;
	Piece[] playerPieces;
	Card[] playerHand;
	Piece[] enemyPieces;
	Card[] enemyHand;

	// Use this for initialization
	void Start () {
		board = new Board();
	}

   // Update is called once per frame
   void Update() {
      if (Input.GetKey(KeyCode.Escape)) {
         SceneManager.LoadScene("Esc Menu");
      }
   }
}
