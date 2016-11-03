using UnityEngine;
using System.Collections;

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
	void Update () {
		
	}
}
