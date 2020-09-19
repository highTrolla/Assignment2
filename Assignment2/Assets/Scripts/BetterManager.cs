using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterManager : MonoBehaviour
{

    public Vector2 gridSize;

    public Cube cube1;
    public Cube cube2;
    public Cube cube3;
    public Cube cube4;
    public Cube cube5;
    public Cube cube6;
    public Cube cube7;
    public Cube cube8;
    public Cube cube9;

    private Cube[,] arrayOfCubes;



    // Start is called before the first frame update
    void Start()
    {
        arrayOfCubes = new Cube[,] { { cube1, cube4, cube7 }, { cube2, cube5, cube8 }, { cube3, cube6, cube9 } };
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i <= 9; i++)
        {
            string key = "[" + i.ToString() + "]";
            if (Input.GetKeyDown(key))
            {
                Vector2 targetPos = new Vector2((i - 1) % gridSize.x, Mathf.Floor((i - 1) / gridSize.y));
            }
        }        
    }
}
