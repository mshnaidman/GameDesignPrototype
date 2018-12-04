using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour {
    public Text loseText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player2")

        {

            loseText.text = "Orange wins!!!";
            Time.timeScale = 0.0f;

        }

        if (col.gameObject.name == "Player1")

        {

            loseText.text = "Green Wins!!!";
            Time.timeScale = 0.0f;

        }

    }
}
