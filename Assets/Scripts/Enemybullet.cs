using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    public float enemybulletspeed = 3f;

    private void Update()
    {
        transform.Translate(Vector2.right * enemybulletspeed * Time.deltaTime);
        if (transform.position.y <= -5f)
        {
            Destroy(gameObject);    
        }


    }
    

}
