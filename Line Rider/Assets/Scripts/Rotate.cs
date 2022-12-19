using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speedRotate = 75f;

    void Update()
    {
        transform.Rotate(0, 0, 360 * speedRotate * Time.deltaTime);

    }
}