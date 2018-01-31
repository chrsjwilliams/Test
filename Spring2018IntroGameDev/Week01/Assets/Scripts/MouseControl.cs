using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    // Use this for initialization
    void Start ()
    {
	}

    /// <summary>
    /// This is a Unity defined function that is called whenever the mouse is clicked
    /// </summary>
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
                                                                                            Input.mousePosition.y, 
                                                                                            screenPoint.z));
    }

    /// <summary>
    /// This is a Unity defined function that is called whenever we click and drag the mouse
    /// </summary>
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
          
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
