using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlottyBoy : MonoBehaviour {

    Plotter plotter;

	// Use this for initialization
	void Start () {
        plotter = new Plotter();
        plotter.SetInput("-8", "8", "0", "X", "0", "X");
        plotter.SetOrigin(184.8f, 3f, 177.8f);
        plotter.Plot();
	}
	
}
