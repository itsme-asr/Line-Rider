using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class Line : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public EdgeCollider2D eCol;
    List<Vector2> points;

    public void updateLine(Vector2 mousePos)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            setPoint(mousePos);
            return;
        }

        if (Vector2.Distance(points.Last(), mousePos) > .1f)
        {
            setPoint(mousePos);
        }
    }

    void setPoint(Vector2 point)
    {
        points.Add(point);

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);
        if (points.Count > 1)
        {
            eCol.points = points.ToArray();
        }
    }


}
