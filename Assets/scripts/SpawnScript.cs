using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject CactusPrefab;
    private GameObject enemy;
    void Start()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void SpawnEnemy() {
        enemy = Instantiate(CactusPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
    } 
}
