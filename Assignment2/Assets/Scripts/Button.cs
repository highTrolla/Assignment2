using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Cube cube;

    public void Click()
    {
        cube.IGotClicked();
    }
}
