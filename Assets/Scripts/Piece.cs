using UnityEngine;
using System.Collections;

public class Piece : MonoBehaviour {
	bool isGrey = true;
	bool isDead = false;
	bool isSelected = false;
	bool isStronghold = false;

	Point position;

	public bool IsGrey () {
		return isGrey;
	}

	public bool IsDead () {
		return isDead;
	}

	public bool IsSelected () {
		return isSelected;
	}

	public bool IsStronghold () {
		return isStronghold;
	}

	public void Select () {
		isSelected = true;
	}

	public void Deselect () {
		isSelected = false;
	}

	public Point GetPosition() {
		return position;
	}

	public void SetPosition(int x, int y) {
		position.SetPoint (x, y);
	}

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