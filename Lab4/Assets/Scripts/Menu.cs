using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{   
  public GameObject Panel;
   public void PauseButton(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     Time.timeScale = 1f;
   }
   
}
