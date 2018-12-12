using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour {

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
        _spawnTimer = Random.Range(3f, 10f);

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
        _spawnTimer -= Time.deltaTime;

        if (_spawnTimer <= 0)
        {
            int randInt = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.repeatSounds.Length - 1));
            float randPitch = Random.Range(0.8f, 1.3f);
            Vector3 position = Vector3.zero;
            position.x = Random.Range(playerPos.x - 30, playerPos.x + 30);
            position.z = Random.Range(playerPos.z - 15, playerPos.z + 15);
            Instantiate(demonPrefab, position, Quaternion.identity);
            SoundCS.me.SpawnSound(SoundCS.me.repeatSounds[randInt], position, 1f, 0, randPitch);
            

            //check distance from player
            float distance = Vector3.Distance(position, playerPos);

            if (distance <= 8f)
            {
                int randInt2 = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.gasps.Length - 1));
                float randPitch2 = Random.Range(1.1f, 1.4f);
                Sound.me.PlaySound(SoundCS.me.gasps[randInt2], 0.5f, randPitch2);
            }

            _spawnTimer = Random.Range(7f, 30f);
        }
    }
}
