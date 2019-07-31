using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{
    private GameObject crystal;
    private int collected = 0;
    Text winningText;


	private void Update() {
  
        winningText = GetComponent<Text>();
        crystal = GameObject.FindGameObjectWithTag("crystal");
        collected = crystal.GetComponent<Crystal>().returnCollected();
      
        winningText.text = " Collected " + collected + " out of 10 Crystals !";
	}

	public void ResetScene() {
        
        // Reset the scene when the user clicks the sign post
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}
}