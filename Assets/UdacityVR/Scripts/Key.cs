using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	//Create a reference to the KeyPoofPrefab and Door

	public GameObject keyPoof;
    public GameObject door;

    public float floatSpeed;
    public float floatAmplitude;
    private Vector3 floatPosition;
	private Vector3 keyPosition = Vector3.zero;
    private float xValue;
    private float yValue;
    private float zValue;

    private void Start()
    {
        keyPosition = gameObject.transform.position;
        xValue = keyPosition.x;
        yValue = keyPosition.y;
        zValue = keyPosition.z;
    }

	private void FixedUpdate()
	{
        floatPosition.x = xValue;
        floatPosition.y = yValue + floatAmplitude * Mathf.Sin(floatSpeed * Time.deltaTime);
        floatPosition.z = zValue;
        transform.position = floatPosition;
	}



	public void OnKeyClicked()
	{

        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically

        Object.Instantiate(keyPoof, keyPosition, Quaternion.Euler(-90, 0, 0));

        // Call the Unlock() method on the Door
        door.GetComponent<Door>().Unlock();

		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);


    }



}
