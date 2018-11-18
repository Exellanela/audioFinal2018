using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCS : MonoBehaviour {

    public GameObject demonPrefab;
    GameObject player;
    Vector3 playerPos;
    public float _spawnTimer;


    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _spawnTimer = Random.Range(7f, 30f);
    }

    public void Update()
    {
        playerPos = player.transform.position;

        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            Vector3 position = Vector3.zero;
            position.x = Random.Range(playerPos.x - 20, playerPos.x + 20);
            position.z = Random.Range(playerPos.z - 20, playerPos.z + 20);
            Instantiate(demonPrefab, position, Quaternion.identity);

            _spawnTimer = Random.Range(7f, 30f);
        }
    }
}
