using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffroomButton : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        Debug.Log("Staff room clicked successfully");
    }

    private void OnMouseEnter()
    {
        var artcadeButton = GameObject.Find("door").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3(pos.x, pos.y, (float)(pos.z-0.05));
    }

    private void OnMouseExit()
    {
        var artcadeButton = GameObject.Find("door").GetComponent<Transform>();
        var pos = artcadeButton.position;
        artcadeButton.position = new Vector3(pos.x, pos.y, (float)(pos.z+0.05));
    }
}
