using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerBallScript : MonoBehaviour {

    //public GameObject RollerBall1;

	// Use this for initialization
	void Start () {
        
	}

    public OVRInput.Controller controller = OVRInput.Controller.LTouch;
	
	// Update is called once per frame
	void Update () {
        transform.position = OVRInput.GetLocalControllerPosition(controller);
        transform.rotation = OVRInput.GetLocalControllerRotation(controller);

        float trigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, controller);
        transform.localScale = Vector3.one * (0.05f + 0.1f * trigger);

        float grip = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);
        GetComponent<Renderer>().material.color = Color.red * grip + (1 - grip) * Color.blue;

        // gameObject.transform.localScale += OVRInput.GetLocalControllerPosition();
	}
}
