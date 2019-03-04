using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	private GameObject player; //プレイヤーオブジェクト
	private Vector3 offset;
    private float angle;

	void Start () {
        player = GameObject.Find("Player");
		offset = this.transform.position - player.transform.position;

	}

	void Update () {
		this.transform.position = player.transform.position + offset;
        angle = player.gameObject.GetComponent<Player>().moveAngle;
        transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);
	}
}
