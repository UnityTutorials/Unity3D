using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewObjects : MonoBehaviour {

    public int RAD;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void DetectObjects()
    {
        Collider[] myDetectedObjects = Physics.OverlapSphere(transform.position, RAD);

        int i = 0;
        while (i < myDetectedObjects.Length && myDetectedObjects[i].gameObject.transform.tag != "Player")
        {
            // Do whatever you want with these detected colliders.

            Debug.Log("I See You!");

            i++;
        }
    }

    private void OnMouseDown()
    {
        DetectObjects();
    }
}
