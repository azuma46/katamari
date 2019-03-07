using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class result : MonoBehaviour {

    private GameObject result_object;
    private Object_Data result_data;
    public Text score;

	void Start () {
        result_object = Game_Manager.getPlayer;
        result_data = result_object.gameObject.GetComponent<Player>().getObject_Data();
        Destroy(result_object.GetComponent<Player>());
        Destroy(result_object.GetComponent<Rigidbody>());
        result_object.transform.position = transform.position;

        score.text = "塊LEVEL：" + result_data.Object_Level.ToString() + "\n"
                    + "塊の大きさ:\n" + result_data.Add_Radius + "m\n";
        }

    public void Scene_Load()
    {
        SceneManager.MoveGameObjectToScene(result_object, SceneManager.GetActiveScene());
        SceneManager.LoadScene("Stage_Select");
    }
}
