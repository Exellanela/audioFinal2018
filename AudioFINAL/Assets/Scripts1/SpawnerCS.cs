using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCS : MonoBehaviour {

    public GameObject demonPrefab;
    public GameObject treePrefab;
    public GameObject housePrefab;

    GameObject player;
    Vector3 playerPos;
    public float _spawnTimer;

    public int maxNumTrees;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _spawnTimer = Random.Range(7f, 30f);

        HouseSpawn();

        //TREE SPAWN
        for (int i = 0; i < maxNumTrees; i++)
        {
            float randX = Random.Range(-97f, 100f);
            float randZ = Random.Range(-35f, 170f);
            float randScale = Random.Range(1f, 2.5f);
            Vector3 position = Vector3.zero;
            position.x = randX;
            position.y = -1.3f;
            position.z = randZ;
            GameObject treeObj = Instantiate(treePrefab, position, Quaternion.identity);
            treeObj.transform.localScale = new Vector3(randScale, randScale, randScale);
        }
    }

    public void HouseSpawn()
    {
        //HOUSE SPAWN
        float randX = Random.Range(-80f, 80f);
        float randZ = Random.Range(-20f, 150f);
        Vector3 position = Vector3.zero;
        position.x = randX;
        position.y = 2f;
        position.z = randZ;
        Instantiate(housePrefab, position, Quaternion.identity);
    }

    void Update()
    {
        playerPos = player.transform.position;

        //DEMON SPAWN
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            Vector3 position = Vector3.zero;
            position.x = Random.Range(playerPos.x - 15, playerPos.x + 15);
            position.z = Random.Range(playerPos.z - 8, playerPos.z + 8);
            Instantiate(demonPrefab, position, Quaternion.identity);

            //Debug.Log(position.x);

            _spawnTimer = Random.Range(7f, 30f);
        }
    }
}
