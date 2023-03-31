using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float bulletspeed;

    private void Update()
    {
        transform.Translate(Vector2.right * bulletspeed * Time.deltaTime);
        if (transform.position.y >= 5)
        {
            gameObject.SetActive(false);
        }
        
    }
    
}
