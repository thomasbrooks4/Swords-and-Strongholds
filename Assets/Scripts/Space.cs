using UnityEngine;
using System.Collections;

public class Space : MonoBehaviour {
   // Coordinates of a vector
   public Vector3 coordinates = Vector3.zero;

   public Color BoardColor;

   public Piece piece;

   public virtual void Edge() {
   }
}
