using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlotFromInput : MonoBehaviour {

	public Text[] textRef;
	private Plotter plotter;

	// Use this for initialization
	void Start () {
		plotter = new Plotter ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider obj) {
		plotter.SetInput (textRef [0].text, textRef [1].text, textRef [2].text, textRef [3].text, textRef [4].text, textRef [5].text);
		plotter.Plot ();
	}
}
