using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public Rigidbody2D rb;

    public void playLevel()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }


}
