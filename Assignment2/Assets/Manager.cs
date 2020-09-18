using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Manager : MonoBehaviour
{
    public Cube cube1;
    public Cube cube2;
    public Cube cube3;
    public Cube cube4;
    public Cube cube5;
    public Cube cube6;
    public Cube cube7;
    public Cube cube8;
    public Cube cube9;
    

    public GameObject winner;

    void Start()
    {
        
    }

    void Update()
    {
        if (cube1.isFlipped && cube2.isFlipped && cube3.isFlipped && cube4.isFlipped && cube5.isFlipped && cube6.isFlipped && cube7.isFlipped && cube8.isFlipped && cube9.isFlipped)
        {
            Win();
        }

        if (Input.GetKeyDown("[1]"))
        {
            cube1.Flip();
            cube2.Flip();
            cube4.Flip();
        }
        if (Input.GetKeyDown("[2]"))
        {
            cube1.Flip();
            cube2.Flip();
            cube3.Flip();
            cube5.Flip();
        }
        if (Input.GetKeyDown("[3]"))
        {
            cube2.Flip();
            cube3.Flip();
            cube6.Flip();
        }
        if (Input.GetKeyDown("[4]"))
        {
            cube1.Flip();
            cube4.Flip();
            cube5.Flip();
            cube7.Flip();
        }
        if (Input.GetKeyDown("[5]"))
        {
            cube2.Flip();
            cube4.Flip();
            cube5.Flip();
            cube6.Flip();
            cube8.Flip();
        }
        if (Input.GetKeyDown("[6]"))
        {
            cube3.Flip();
            cube5.Flip();
            cube6.Flip();
            cube9.Flip();
        }
        if (Input.GetKeyDown("[7]"))
        {
            cube4.Flip();
            cube7.Flip();
            cube8.Flip();
        }
        if (Input.GetKeyDown("[8]"))
        {
            cube5.Flip();
            cube7.Flip();
            cube8.Flip();
            cube9.Flip();
        }
        if (Input.GetKeyDown("[9]"))
        {
            cube6.Flip();
            cube8.Flip();
            cube9.Flip();
        }
    }

    public void Win()
    {
        Instantiate(winner, transform.position, Quaternion.identity);
        cube1.isFlipped = false;
    }


}
