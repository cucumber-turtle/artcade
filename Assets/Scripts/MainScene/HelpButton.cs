using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButton : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        Debug.Log("Help button clicked successfully");
    }

    private void OnMouseEnter()
    {
        var artcadeButton = GameObject.Find("help").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3(pos.x, (float)(pos.y-0.05), pos.z);
    }

    private void OnMouseExit()
    {
        var artcadeButton = GameObject.Find("help").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3(pos.x, (float)(pos.y+0.05), pos.z);
    }
}
