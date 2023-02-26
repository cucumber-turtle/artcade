using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtcadeButton : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        Debug.Log("Button clicked successfully");
    }

    private void OnMouseEnter()
    {
        var artcadeButton = GameObject.Find("artcade").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3(pos.x, (float)(pos.y-0.2), pos.z);
    }

    private void OnMouseExit()
    {
        var artcadeButton = GameObject.Find("artcade").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3(pos.x, (float)(pos.y+0.2), pos.z);
    }
}
