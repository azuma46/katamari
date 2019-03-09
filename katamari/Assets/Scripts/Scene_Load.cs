using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Load : MonoBehaviour {
    
    public void SceneLoad_01()
    {
        SceneManager.LoadScene("Stage_01");
    }

    public void SceneLoad_02()
    {
        SceneManager.LoadScene("Stage_02");
    }

    public void SceneLoad_PlayWay()
    {
        SceneManager.LoadScene("Play_Way");
    }

    public void SceneLoad_StageSelect_01()
    {
        //メニュー画面から移動するのでtimesacle,playerの処理
        SceneManager.MoveGameObjectToScene(GameObject.Find("Player"), SceneManager.GetActiveScene());
        SceneManager.LoadScene("Stage_Select");
        Time.timeScale = 1.0f;
    }

    public void SceneLoad_StageSelect_02()
    {
        //操作説明画面の処理
        SceneManager.LoadScene("Stage_Select");
    }

    public void SceneLoad_Result()
    {
        SceneManager.LoadScene("Result");
    }
}
