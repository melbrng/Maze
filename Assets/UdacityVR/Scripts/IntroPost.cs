using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPost : MonoBehaviour {

    public Animator postAnimator;
    public string postTriggerName;

	
	public void OnPostClicked () {
        postAnimator.SetTrigger(postTriggerName);
	}
}
