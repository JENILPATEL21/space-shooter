using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float enemyspeed;

    public Transform[] cannons;

    public GameObject enemybullet;

    public float health = 10f;

    public Healthbar healthbar;

    float barsize = 1f;
    float damage = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemyfire());
        damage = barsize / health;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * enemyspeed *Time.deltaTime);
        if (transform.position.y <= -5f)
        {
            Destroy(gameObject);
        }
    }

    void enemybulletfire()
    {
        for(int i = 0; i < cannons.Length; i++)
        {
            GameObject bullet = Instantiate(enemybullet, cannons[i]);
            bullet.transform.position = cannons[i].position;
        }
    }
    IEnumerator Enemyfire()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            enemybulletfire();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            decreasehealth();
            collision.gameObject.SetActive(false);
            if(health <= 0)
            {
                Destroy(gameObject);
            }    
            
        }
    }
    void decreasehealth()
    {
        if (health > 0)
        {
            health -= 1;
            barsize = barsize - damage;
            healthbar.setsize(barsize);
        }
    }
}
