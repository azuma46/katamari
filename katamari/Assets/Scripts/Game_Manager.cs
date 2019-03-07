using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager :MonoBehaviour {

    public Text now_level;
    public Text timer;

    public GameObject menu_panel;
    private bool menu_on;

    public int time;
    private int min;
    private float sec;

    public int clear_level;

    private GameObject getPlayer;
    private int level = -1;



    void Start () {
        min = time / 60;
        sec = time % 60;
        now_level.text = "";
        getPlayer = GameObject.Find("Player");
        menu_on = false;
    }

	void Update () {
        level = getPlayer.gameObject.GetComponent<Player>().getObject_Level();//playerのレベルを更新
        now_level.text = level.ToString();//playerのレベルを更新

        //ESCでゲームを終了
        if (Input.GetKey(KeyCode.Escape)) Application.Quit();
        if (Input.GetKeyDown("m"))
        {
            if (menu_on == false)
            {
                menu_panel.SetActive(true);
                menu_on = true;
            }
            else
            {
                menu_panel.SetActive(false);
                menu_on = false;
            }
        }

        sec -= Time.deltaTime;
        if (sec <= 0)
        {
            min--;
            sec = 59f;
        }

        timer.text = min.ToString("00") + ":" + sec.ToString("00");
    }
}
