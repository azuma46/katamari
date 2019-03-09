using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	private GameObject player; //プレイヤーオブジェクト
    private GameObject main_camera; //カメラオブジェクト
    private int camera_level = 5;
	private Vector3 offset;
    private float angle;

	void Start () {
        player = GameObject.Find("Player");
        main_camera = GameObject.Find("Main Cameara");
		offset = this.transform.position - player.transform.position;

	}

	void Update () {
		this.transform.position = player.transform.position + offset;
        angle = player.gameObject.GetComponent<Player>().moveAngle;
        transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);
        if (camera_level <= player.gameObject.GetComponent<Player>().getObject_Level())
        {
            main_camera.transform.position = main_camera.transform.position;
            camera_level += 5;
        }
	}
}
