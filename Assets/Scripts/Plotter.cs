using UnityEngine;
using NCalc;

public class Plotter
{
    Expression xlower, xupper,
        ylower, yupper,
        zlower, zupper;

    private Vector3 origin = new Vector3(0f, 0f, 0f);

    private const double FREQUENCY = 10;

    public Plotter()
    {
        xlower = new Expression("1");
        xupper = new Expression("2");
        ylower = new Expression("0*[X]");
        yupper = new Expression("[X]");
        zlower = new Expression("0*[X]+0*[Y]");
        zupper = new Expression("[X] + [Y]");
    }

    public void SetInput(string a, string b, string c, string d, string e, string f)
    {
        xlower = new Expression(a);
        xupper = new Expression(b);
        ylower = new Expression(c);
        yupper = new Expression(d);
        zlower = new Expression(e);
        zupper = new Expression(f);
    }

    public void SetOrigin(float x, float y, float z)
    {
        origin = new Vector3(x, y, z);
    }

    public void Plot()
    {
        PlotLimits();
    }

    private GameObject Plot(double x, double y, double z)
    {
        GameObject point = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        point.transform.position = new Vector3((float)x + origin.x, (float)y + origin.y, (float)z + origin.z);
      //  point.transform.position = new Vector3((float)x, (float)y, (float)z);
        point.transform.localScale -= new Vector3(0.95f, 0.95f, 0.95f);
        point.GetComponent<Collider>().isTrigger = true;
        Color color = new Color(1, 0, 1, 1);
        MeshRenderer rend = point.GetComponent<MeshRenderer>();
        rend.material.color = color;
        return point;
    }

    private void PlotLimits()

    {
        GameObject graph = new GameObject();
        graph.name = "Graph";
        Debug.Log(xlower.Evaluate().GetType());
        double x = System.Convert.ToDouble(xlower.Evaluate());


        ylower.Parameters["X"] = x;
        double y = System.Convert.ToDouble(ylower.Evaluate());

        zlower.Parameters["X"] = x;
        zlower.Parameters["Y"] = y;
        double z = System.Convert.ToDouble(zlower.Evaluate());

        double i = System.Convert.ToDouble(xupper.Evaluate());
        while (x <= i)
        {
            yupper.Parameters["X"] = x;
            double j = System.Convert.ToDouble(yupper.Evaluate());
            while (y <= j)
            {
                zupper.Parameters["X"] = x;
                zupper.Parameters["Y"] = y;
                double k = System.Convert.ToDouble(zupper.Evaluate());
                while (z <= k)
                {// add thing
                    GameObject point = Plot(x, y, z);
                    point.transform.parent = graph.transform;
                    z += (1 / FREQUENCY);
                }
                y += (1 / FREQUENCY);
            }
            x += (1 / FREQUENCY);
        }

    }

}
