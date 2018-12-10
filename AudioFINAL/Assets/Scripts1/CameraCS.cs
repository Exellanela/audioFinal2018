using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCS : MonoBehaviour {
    //GOES ON CAMERA

    public GameObject player;
    private Vector3 _playerPos;

    Vector3 cameraPos;


    void Awake()
    {
        
    }

    void Start()
    {
        _playerPos = player.transform.position;
    }

    void Update()
    {
        cameraPos = transform.position;
        cameraPos.x = Mathf.Clamp(cameraPos.x, -83f, 85f);
        //cameraPos.y = 
    }

    void LateUpdate()
    {

    }
}
