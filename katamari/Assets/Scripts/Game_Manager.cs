using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager :MonoBehaviour {

    public Text now_level;
    //public Text timer;

    private GameObject getPlayer;
    private int level = -1;

    void Start () {
        now_level.text = "";
        getPlayer = GameObject.Find("Player");
    }

	void Update () {
        level = getPlayer.gameObject.GetComponent<Player>().getObject_Level();
        now_level.text = level.ToString();
    }
}
