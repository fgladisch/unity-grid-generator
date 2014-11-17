using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridGenerator : MonoBehaviour
{
    private GridTile[,] grid;

    private List<GridTile> gridTiles;
    private List<float> xValues;
    private List<float> yValues;

    public GridTile[,] Grid {
        get {
            return grid;
        }
    }

    void Start ()
    {
        gridTiles = new List<GridTile> ();
        xValues = new List<float> ();
        yValues = new List<float> ();
        foreach (Transform child in transform) {
            bool wall = false;
            if (child.tag == "Wall") {
                wall = true;
            }
            gridTiles.Add (new GridTile (child.position.x, child.position.y, wall));
            if (!xValues.Contains (child.position.x)) {
                xValues.Add (child.position.x);
            }
            if (!yValues.Contains (child.position.y)) {
                yValues.Add (child.position.y);
            }
        }
        xValues.Sort ();
        yValues.Sort ();
        yValues.Reverse ();
        float[] xValuesSorted = xValues.ToArray ();
        float[] yValuesSorted = yValues.ToArray ();
        grid = new GridTile[xValues.Count, yValues.Count];
        string result = "Grid:\n";
        for (int y = 0; y < yValuesSorted.Length; y++) {
            for (int x = 0; x < xValuesSorted.Length; x++) {
                foreach (GridTile tile in gridTiles) {
                    if (tile.x == xValuesSorted [x] && tile.y == yValuesSorted [y]) {
                        grid [x, y] = tile;
                        if (tile.wall) {
                            result += "1 ";
                        } else {
                            result += "0 ";
                        }
                    }
                }
            }
            result += "\n";
        }
        Debug.Log (result);
    }
}
