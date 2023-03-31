using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    public Transform bar;
    public void setsize(float size)
    {
        bar.localScale = new Vector2(size, 1f);
    }
}
