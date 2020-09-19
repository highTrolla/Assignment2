using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public bool isFlipped;
    public Renderer Renderer;
    public Manager manager;
    public bool clickBool;

    public Vector2 gridPos;

    void Start()
    {
        isFlipped = false;
        clickBool = false;
    }

    public void Flip()
    {
        transform.DOPunchScale(Vector3.one * 1.25f, 1f);
        if (isFlipped)
        {
            Renderer.material.DOColor(Color.cyan, 1f);
            Manager.winNumber -= 1;
        }
        else
        {
            Renderer.material.DOColor(Color.red, 1f);
            Manager.winNumber += 1;
        }
        isFlipped = !isFlipped;
    }

    public void IGotClicked()
    {
        clickBool = true;
    }
}
