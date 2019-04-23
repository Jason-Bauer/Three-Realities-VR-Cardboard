using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    public GameObject panelh, texth;
    public bool S1, S2, S3,Texthold;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!Texthold)
        {
            if (S1)
            {
                texth.GetComponent<Text>().text = "Objective: Find the switch";
            }
            else if (S2)
            {
                texth.GetComponent<Text>().text = "Objective: Look Around";
            }
            else if (S3)
            {
                texth.GetComponent<Text>().text = "Welcome to Space";
            }
            else
            {
                texth.GetComponent<Text>().text = "How did you get this text?";
            }
        }
    }
    public void SetText(string t)
    {
        Texthold = true;
        texth.GetComponent<Text>().text = t;
    }
    public void flipText()
    {
        Texthold = false;
        
    }
}
