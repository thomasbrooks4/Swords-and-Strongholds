using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
   public void OnPlay() {
      SceneManager.LoadScene("Board");
   }

   public void OnExit() {
      Application.Quit();
   }
}
