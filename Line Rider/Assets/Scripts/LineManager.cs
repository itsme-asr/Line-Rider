using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    public GameObject linePreFab;
    Line activeLine;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGo = Instantiate(linePreFab);
            activeLine = lineGo.GetComponent<Line>();
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.updateLine(mousePos);
        }


    }
}
