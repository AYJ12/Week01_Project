using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 _dirPos;
    private GameObject player;
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _dirPos = _camera.transform.position - player.transform.position;
        _camera.transform.position = new Vector3(_camera.transform.position.x - _dirPos.x, _camera.transform.position.y - _dirPos.y, _camera.transform.position.z);
    }

    
}
