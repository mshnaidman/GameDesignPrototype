using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorShring : MonoBehaviour {

    public Vector3 currentScaleSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = transform.localScale - currentScaleSpeed * Time.deltaTime;
    }
}
