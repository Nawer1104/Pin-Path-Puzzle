using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public bool isLeft;

    private bool isClicked = false;

    private void OnMouseDown()
    {
        if (isClicked) return;

        isClicked = true;

        if (isLeft)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 90f);
        }
    }
}
