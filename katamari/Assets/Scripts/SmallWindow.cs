using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallWindow : TokenDataBase {

    public Text hit_object_name;

    private GameObject getPlayer;
    private GameObject hit_object;
    private GameObject idle_object = null;
    private string object_name;
    private float rotateY = 0.0f;

	void Start ()
    {
        hit_object_name.text = " ";
        getPlayer = GameObject.Find("Player");
	}
	
	void Update ()
    {
        object_name = getPlayer.GetComponent<Player>().hit_object_name;
        hit_object = (GameObject)Resources.Load("prefabs/" + object_name);
        if (hit_object != idle_object)
        {
            Destroy(idle_object);
            idle_object = Instantiate(hit_object, transform.position, Quaternion.identity);
            idle_object.transform.rotation = Quaternion.Euler(0.0f, rotateY, 0.0f);
        }

        rotateY++;

        hit_object_name.text = object_name;
    }
}
