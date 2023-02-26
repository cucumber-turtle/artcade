using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipButton : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        Debug.Log("Skip play button clicked successfully");
    }

    private void OnMouseEnter()
    {
        var artcadeButton = GameObject.Find("skip").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3((float)(pos.x+0.1), pos.y, pos.z);
    }

    private void OnMouseExit()
    {
        var artcadeButton = GameObject.Find("skip").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3((float)(pos.x-0.1), pos.y, pos.z);
    }
}
