using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private float speed = 5;
    public Transform bulletspawnpoint;
    public float fireRate;
    float nextfiretime;
    public int playerhealth = 100;
    public int currenthealth;
    public TextMeshProUGUI health;


    private void Start()
    {
        currenthealth = playerhealth;
    }
    // Update is called once per frame
    void Update()
    {
        //simple movements using translate
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontal * Time.deltaTime * 10);
        transform.Translate(Vector3.up * vertical * Time.deltaTime * 10);

        //movement boundry
        if (transform.position.x >= 8.4f)
        {
            transform.position = new Vector3(8.4f, transform.position.y, 0f);
        } else if (transform.position.x <= -8.4f)
        {
            transform.position = new Vector3(-8.4f, transform.position.y, 0f);
        }
        if (transform.position.y >= 4.5)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0f);
        }
        else if (transform.position.y <= -4.5)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, 0f);
        }

        //bullet spawn
        nextfiretime = Time.time + fireRate;
        GameObject bullet = ObjPooling.instance.GetPooledObj();
        bullet.transform.position = bulletspawnpoint.position;
        bullet.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemybullet")
        {
            currenthealth -= 10;
            health.text = "Health:" + currenthealth.ToString();
            if(currenthealth <= 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0f;

            }
        }
    }
}
