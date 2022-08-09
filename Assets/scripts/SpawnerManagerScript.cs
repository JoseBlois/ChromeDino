using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3f, 2f);
        //SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        SpawnScript[] scripts = gameObject.GetComponentsInChildren<SpawnScript>();
        int rd = Random.Range(0, 2);

        scripts[rd].SpawnEnemy();
    }
}
