using UnityEngine;
using System.Collections;

public class Tile : Space {
   bool isStronghold = false;

   void OnMouseEnter() {
      transform.GetComponent<Renderer>().material.color = Color.blue;
   }

   void OnMouseExit() {
      transform.GetComponent<Renderer>().material.color = BoardColor;
   }

   void OnMouseDown() {
      Debug.Log("Tile Coordinates are (" + coordinates.x + ", " + coordinates.z + ")");
   }

   // Returns if the current space is a stronghold
   public bool IsStronghold() {
      return isStronghold;
   }
}
