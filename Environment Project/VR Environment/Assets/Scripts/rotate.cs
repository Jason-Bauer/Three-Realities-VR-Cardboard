using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    bool rotating;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (rotating)
        {
            this.gameObject.transform.Rotate(new Vector3(0, 1, 0));
        }
	}
    public void setrot(bool r)
    {
        rotating = r;
    }
}
