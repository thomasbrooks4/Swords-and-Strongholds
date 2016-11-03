using UnityEngine;
using System.Collections;

public class Piece : MonoBehaviour {
	bool isGrey = true;
	bool isDead = false;
	bool isSelected = false;
	bool isStronghold = false;

	Point position;

	// Either a piece is black or grey
	public bool IsGrey () {
		return isGrey;
	}

	// If dead then the piece will be unplayable and on the side
	public bool IsDead () {
		return isDead;
	}

	// If selected then move actions and cards played will target this piece
	public bool IsSelected () {
		return isSelected;
	}

	// If stronghold then the piece cannot move and locks surrounding intersections
	public bool IsStronghold () {
		return isStronghold;
	}

	// Selects the current piece
	public void Select () {
		isSelected = true;
	}

	// Deselects the current piece
	public void Deselect () {
		isSelected = false;
	}

	// Will be needed when finding the closest piece
	public Point GetPosition() {
		return position;
	}

	// This will allow the piece to move on the board
	// During the initalization of the game, the pieces will jump to the set
	// position instead of gradually moving there
	// During the game loop, the set position will be locked to the
	// surrounding intersections
	public void SetPosition(int x, int y) {
		position.SetPoint (x, y);
	}

	// Takes piece out of board and labels as dead
	public void Death () {
		isDead = true;
		position = null;
	}
}

public class Point {
	int x;
	int y;

	public void SetPoint(int a, int b) {
		x = a;
		y = b;
	}
}

// This class will be specific to a controllable player
public class PlayerPiece : Piece {
	void Start () {

	}

	void Update () {

	}
}

// This class will be specific to an AI or an opponent on a different client
public class EnemyPiece : Piece {
	void Start () {

	}

	void Update () {

	}
}