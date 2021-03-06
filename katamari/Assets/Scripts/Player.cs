﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Token {

    public float speed = 10.0f;
    private int Player_Level=1;
    private float Player_EXP = 0.0f;
    private float Next_EXP;
    private new Rigidbody rigidbody;
    private SphereCollider sphereCollider;

    public float moveAngle=0.0f;
    public string hit_object_name;

    private TextAsset exp_text;
    private string[] text_line;

    private void Start()
    {
        exp_text = Resources.Load("text/exp_data") as TextAsset;
        text_line = exp_text.text.Split(char.Parse("\n"));
        Next_EXP = float.Parse(text_line[0]);
        setObject_Name(this.name);
        setObject_Level(Player_Level);
        setObject_EXP(Player_EXP);
        rigidbody = GetComponent<Rigidbody>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    private void Update()
    {
        // カーソルキーの入力を取得
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey("q")) moveAngle--;
        else if (Input.GetKey("e")) moveAngle++;

        // カーソルキーの入力に合わせて移動方向を設定
        var movement = new Vector3(moveHorizontal, 0, moveVertical);
        var result = Quaternion.Euler(0.0f, moveAngle, 0.0f) * movement;

        // Ridigbody に力を与えて玉を動かす
        rigidbody.AddForce(result * speed);

        //PlayerのEXPがNext EXPを超えたときにレベルが上がる
        if (Next_EXP < Player_EXP)
        {
            Next_EXP = float.Parse(text_line[Player_Level]);//次のレベルアップの経験値をセット
            Player_Level++;//レベルを増加
            setObject_Level(Player_Level);//Playerにレベルをセット
            setObject_EXP(Player_EXP);//PlayerにEXPをセット     
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            //接触したオブジェクトの情報を取得する

            Object_Data object_data = collision.gameObject.GetComponent<Building>().getObject_Data();
            //Debug.Log(object_data.Object_Name);
            //PlayerのObjectLevelと接触したオブジェクトのObjectLevelを比較して塊に引っ付けるかどうかを判定する
            if (Player_Level >= object_data.Object_Level)
            {
                hit_object_name = object_data.Object_Name;
                //引っ付く処理
                collision.transform.parent = transform;
                collision.collider.isTrigger = true;
                Destroy(collision.collider);//引っ付いたオブジェクトのcolliderを消去
                Player_EXP += object_data.Object_EXP;
                sphereCollider.radius = sphereCollider.radius + object_data.Add_Radius;
                setAdd_Radius(sphereCollider.radius);
            }
            else
            {
                //引っ付かなかった場合
                Debug.Log("failed");
            }
        }
    }
}