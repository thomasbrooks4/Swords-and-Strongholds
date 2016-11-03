using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {
	const int INTERSECTION_ROWS = 9;
	const int INTERSECTION_COL = 7;
	const int SQUARE_ROWS = 8;
	const int SQUARE_COL = 6;
	const int TOTAL_ROWS = INTERSECTION_ROWS + SQUARE_ROWS;

	Space[][] board;

	// For loop creating jagged array of intersections and squares
	public Board () {
		//EXAMPLE PSUDOCODE
		board = new Space[TOTAL_ROWS][];
		
		// Loop creating arrays of spaces within board
		for (int i = 0; i < TOTAL_ROWS; i++) {
			if ((i % 2) == 0) {
				board [i] = new Intersection[INTERSECTION_COL];

				for (int j = 0; j < INTERSECTION_COL; j++)
					board [i] [j] = new Intersection ();
				
				if (i == 0 || i == (TOTAL_ROWS - 1)) {
					for (int j = 0; j < INTERSECTION_COL; j++)
						board [i] [j].Edge ();
				} 
				else {
					board [i] [0].Edge ();
					board [i] [INTERSECTION_COL - 1].Edge ();
				}
			} 
			else {
				board [i] = new Square[SQUARE_COL];

				for (int j = 0; j < SQUARE_COL; j++)
					board [i] [j] = new Square ();
			}
		}
	}
}

// The board will be an array of spaces.
// Each space can either be an interseciton or a square
// Intersections can be traversed and squares will hold strongholds
public class Space : MonoBehaviour {
	Piece piece;

	public virtual void Edge () {
	}
}

// Intersections are the lines of the board and can be traversed by pieces
public class Intersection : Space {
	bool isEdge = false;
	bool isTraversable = false;

	// If a piece is moved onto an edge it will be destroyed
	public bool IsEdge () {
		return isEdge;
	}

	public bool IsTraversable () {
		return isTraversable;
	}

	// While creating the board, the edges of the board will be marked
	public override void Edge () {
		isEdge = true;
		isTraversable = false;
	}

	// When a piece is selected the traversable spaces will be highlighted
	public void Traversable () {
		isTraversable = true;
	}
}

// Squares are the squares of the board and will hold stronghold pieces
public class Square : Space {
	bool isStronghold = false;

	// Returns if the current space is a stronghold
	public bool IsStronghold () {
		return isStronghold;
	}
}