using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    //Create a reference to the CoinPoofPrefab

    public GameObject crystalPoof;
    private static int collected = 0;
    private Vector3 _crystalPosition = Vector3.zero;

    private void Awake(){
        _crystalPosition = gameObject.transform.position;
    }

    public void OnCrystalClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

        Object.Instantiate(crystalPoof, _crystalPosition, Quaternion.Euler(0, 0, 0));
        collected += 1;
        Destroy(gameObject);

    }

    public int returnCollected() {

        return collected;
    }

}
