using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager :MonoBehaviour {

    public Text now_level;
    public Text timer;

    public GameObject menu_panel;
    public GameObject result_button;
    private bool menu_on;

    public int time;
    private int min;
    private float sec;

    public int clear_level;

    public static GameObject getPlayer;
    private int level = -1;

    //public static GameObject resultPlayer;
    void Awake()
    {
        getPlayer = GameObject.Find("Player");
        DontDestroyOnLoad(getPlayer);
    }

    void Start () {
        min = time / 60;
        sec = time % 60;
        now_level.text = "";

        menu_on = false;
    }

	void Update () {
        level = getPlayer.gameObject.GetComponent<Player>().getObject_Level();//playerのレベルを更新
        now_level.text = level.ToString();//playerのレベルを更新

        //ESCでゲームを終了
        if (Input.GetKey(KeyCode.Escape)) Application.Quit();

        //メニューを開く
        if (Input.GetKeyDown("m"))
        {
            if (menu_on == false)
            {
                menu_panel.SetActive(true);
                menu_on = true;
                Time.timeScale = 0.0f;
            }
            else
            {
                menu_panel.SetActive(false);
                menu_on = false;
                Time.timeScale = 1.0f;
            }
        }

        //タイマー関連
        sec -= Time.deltaTime;
        if (sec <= 0)
        {
            min--;
            sec = 59f;
        }
        timer.text = min.ToString("00") + ":" + sec.ToString("00");

        if (time <= 0 && sec <= 0) SceneManager.LoadScene("Result");
        if (clear_level <= level) result_button.SetActive(true);
    }
}
