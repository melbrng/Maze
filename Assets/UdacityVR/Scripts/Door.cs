using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    private bool locked = true;
    private bool opening = false;
    private bool doorIsOpen = false;

    public Animator doorAnimator;
    public Animator trollAnimator;
    public string doorTriggerName;
    public string trollTriggerName;

    public AudioClip doorOpened;
    public AudioClip doorLocked;
    private AudioSource _audio = null;

	private void Awake() {
        _audio = gameObject.GetComponent<AudioSource>();

	}


	void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up

        if(opening == true){
            
            doorAnimator.SetTrigger(doorTriggerName);
            trollAnimator.SetTrigger(trollTriggerName);
            opening = false;
           
        }

    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        if (locked == false & doorIsOpen == false){
            opening = true;
            doorIsOpen = true;
            _audio.clip = doorOpened;
            _audio.Play();

        } else if(doorIsOpen == true){
            gameObject.GetComponent<BoxCollider>().isTrigger = true;

        } else {
            // Play a sound to indicate the door is locked
            _audio.clip = doorLocked;
            _audio.Play();
        }

    }

    public void Unlock() {
        // You'll need to set "locked" to false here
        locked = false;

    }
}
