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

    public void SceneLoad_StageSelect()
    {
        SceneManager.LoadScene("Stage_Select");
        Time.timeScale = 1.0f;
    }

    public void SceneLoad_Result()
    {
        SceneManager.LoadScene("Result");
    }
}
