using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    public static int winNumber;

    public GameObject winner;


    void Start()
    {
        
    }

    void Update()
    {
        if (winNumber == 9)
        {
            Win();
            winNumber = 0;
        }

        if (cube1.clickBool)
        {            
            Button1();
            cube1.clickBool = false;
        }
        if (cube2.clickBool)
        {
            Button2();
            cube2.clickBool = false;
        }
        if (cube3.clickBool)
        {
            Button3();
            cube3.clickBool = false;
        }
        if (cube4.clickBool)
        {
            Button4();
            cube4.clickBool = false;
        }
        if (cube5.clickBool)
        {
            Button5();
            cube5.clickBool = false;
        }
        if (cube6.clickBool)
        {
            Button6();
            cube6.clickBool = false;
        }
        if (cube7.clickBool)
        {
            Button7();
            cube7.clickBool = false;
        }
        if (cube8.clickBool)
        {
            Button8();
            cube8.clickBool = false;
        }
        if (cube9.clickBool)
        {
            Button9();
            cube9.clickBool = false;
        }

    }

    public void Win()
    {
        Instantiate(winner, transform.position, Quaternion.identity);
        cube1.isFlipped = false;
    }

    public void Button1()
    {
        cube1.Flip();
        cube2.Flip();
        cube4.Flip();
    }
    public void Button2()
    {
        cube1.Flip();
        cube2.Flip();
        cube3.Flip();
        cube5.Flip();
    }
    public void Button3()
    {
        cube2.Flip();
        cube3.Flip();
        cube6.Flip();
    }
    public void Button4()
    {
        cube1.Flip();
        cube4.Flip();
        cube5.Flip();
        cube7.Flip();
    }
    public void Button5()
    {
        cube2.Flip();
        cube4.Flip();
        cube5.Flip();
        cube6.Flip();
        cube8.Flip();
    }
    public void Button6()
    {
        cube3.Flip();
        cube5.Flip();
        cube6.Flip();
        cube9.Flip();
    }
    public void Button7()
    {
        cube4.Flip();
        cube7.Flip();
        cube8.Flip();
    }
    public void Button8()
    {
        cube5.Flip();
        cube7.Flip();
        cube8.Flip();
        cube9.Flip();
    }
    public void Button9()
    {
        cube6.Flip();
        cube8.Flip();
        cube9.Flip();
    }
}
