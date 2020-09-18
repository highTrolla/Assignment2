using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    public bool isFlipped;
    public Renderer Renderer;
    public Manager manager;
    public Vector2 gridPos;

    // Start is called before the first frame update
    void Start()
    {
        isFlipped = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        Flip();
    }

    public void Flip()
    {
        transform.DOPunchScale(Vector3.one * 1.25f, 1f);

        if (isFlipped)
        {
            Renderer.material.DOColor(Color.cyan, 1f);
            isFlipped = false;
        }
        else
        {
            Renderer.material.DOColor(Color.red, 1f);
            isFlipped = true;
        }
    }


}
