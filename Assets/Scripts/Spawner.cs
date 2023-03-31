using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyspawner());
    }

    IEnumerator enemyspawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            spawnenemy();
        }
    }
    void spawnenemy()
    {
        int randomvalue =Random.Range(0, enemy.Length);
        int randompos = Random.Range(-7, 7);
        Instantiate(enemy[randomvalue], new Vector2(randompos,transform.position.y),Quaternion.identity);
    }
}
