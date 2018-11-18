using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCS : MonoBehaviour {
    //GOES ON CAMERA

    public GameObject player;
    private Vector3 _playerPos;

	private float _setYpos;
    private Vector3 _camPos;
    private Vector3 _offset;

    public void Awake()
    {
        _camPos = transform.position;
        _setYpos = 15f;
    }

    public void Start()
    {
        _camPos = this.transform.position;
        _playerPos = player.transform.position;
        _offset = _camPos - _playerPos;
    }

    public void Update()
    {
        _camPos.y = _setYpos;
        _camPos.y = Mathf.Clamp(_camPos.y, _setYpos, _setYpos);
    }

    public void LateUpdate()
    {
        _camPos = _playerPos + _offset;
    }
}
