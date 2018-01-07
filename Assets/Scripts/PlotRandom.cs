using UnityEngine;
using UnityEngine.UI;


public class PlotRandom : MonoBehaviour {

    public Text[] textRef;
    private Plotter plotter;
    private string[][] graphs;
    Random rnd;

    // Use this for initialization
    void Start () {
        plotter = new Plotter();
        rnd = new Random();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider obj)
    {
       
        plotter.SetInput(textRef[0].text, textRef[1].text, textRef[2].text, textRef[3].text, textRef[4].text, textRef[5].text);
        plotter.Plot();
    }
}
