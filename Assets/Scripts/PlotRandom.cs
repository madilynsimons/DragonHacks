using UnityEngine;
using UnityEngine.UI;


public class PlotRandom : MonoBehaviour {

    public Text[] textRef;
    private Plotter plotter;
    private string[][] graphs;

    // Use this for initialization
    void Start () {
        plotter = new Plotter();
        graphs = new string[5][];

        // Graph 0
        graphs[0][0] = "-10";
        graphs[0][1] = "10";
        graphs[0][2] = "-10";
        graphs[0][3] = "10";
        graphs[0][4] = "0";
        graphs[0][5] = "x + y";

        // Graph 1
        graphs[1][0] = "-10";
        graphs[1][1] = "10";
        graphs[1][2] = "hi";
        graphs[1][3] = "hi";
        graphs[1][4] = "hi";

        // Graph 2
        graphs[2][0] = "-10";
        graphs[2][1] = "10";
        graphs[2][2] = "hi";
        graphs[2][3] = "hi";
        graphs[2][4] = "hi";

        // Graph 3
        graphs[3][0] = "-10";
        graphs[3][1] = "10";
        graphs[3][2] = "hi";
        graphs[3][3] = "hi";
        graphs[3][4] = "hi";

        // Graph 3
        graphs[4][0] = "-10";
        graphs[4][1] = "10";
        graphs[4][2] = "hi";
        graphs[4][3] = "hi";
        graphs[4][4] = "hi";

        plotter.SetInput(graphs[0][0], graphs[1][1], graphs[2][2], graphs[3][3], graphs[4][4], graphs[5][5]);
        plotter.Plot();
        Debug.Log("Plotted");

    }

    void OnTriggerEnter(Collider obj)
    {
        int i = Random.Range(0, 4);
        plotter.SetInput(graphs[i][0], graphs[i][1], graphs[i][2], graphs[i][3], graphs[i][4], graphs[i][5]);
        plotter.Plot();
    }
}
