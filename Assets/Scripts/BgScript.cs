using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScript : MonoBehaviour
{
    public Renderer renderer;
    float bgspeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset += new Vector2(0, bgspeed * Time.deltaTime);
    }
}
