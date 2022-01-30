using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;    // Хранит связь с игроком
    public float distance;

    // Use this for initialization
    void Start () {
		
	}
	
	void LateUpdate () {
        Vector3 offset = new Vector3(0,0,-distance);
        transform.position = player.transform.position+offset;
	}
}
