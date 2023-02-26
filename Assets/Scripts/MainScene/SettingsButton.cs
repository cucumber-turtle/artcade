using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        Debug.Log("Settings button clicked successfully");
    }

    private void OnMouseEnter()
    {
        var artcadeButton = GameObject.Find("settings").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3(pos.x, (float)(pos.y-0.1), pos.z);
    }

    private void OnMouseExit()
    {
        var artcadeButton = GameObject.Find("settings").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3(pos.x, (float)(pos.y+0.1), pos.z);
    }
}
