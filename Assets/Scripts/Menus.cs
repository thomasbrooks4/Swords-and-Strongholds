using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {
   public void OnPlay() {
      SceneManager.LoadScene("Board");
   }

   public void OnInstructions() {
      SceneManager.LoadScene("Instructions");
   }

   public void OnExit() {
      Application.Quit();
   }

   public void OnMainMenu() {
      SceneManager.LoadScene("Main Menu");
   }
}
