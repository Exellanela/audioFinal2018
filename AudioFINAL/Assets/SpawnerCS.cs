using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCS : MonoBehaviour {

    public GameObject demonPrefab;
    public GameObject treePrefab;

    GameObject player;
    Vector3 playerPos;
    public float _spawnTimer;

    int maxNumTrees = 50;


    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _spawnTimer = Random.Range(7f, 30f);
    }

    public void Update()
    {
        playerPos = player.transform.position;

        //DEMON SPAWN
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            Vector3 position = Vector3.zero;
            position.x = Random.Range(playerPos.x - 30, playerPos.x + 30);
            position.z = Random.Range(playerPos.z - 20, playerPos.z + 20);
            Instantiate(demonPrefab, position, Quaternion.identity);

            _spawnTimer = Random.Range(7f, 30f);
        }


        //TREE SPAWN
        /* NOT WORKING RN :(
        for (int i=0; i < maxNumTrees; i++)
        {
            float randX = Random.Range(-97f, 10f);
            float randZ = Random.Range(-35f, 170f);
            Vector3 position = Vector3.zero;
            position.x = randX;
            position.y = 1.2f;
            position.z = randZ;
            Instantiate(treePrefab, position, Quaternion.identity);
            //Debug.Log(i);
        }
        */
    }
}
