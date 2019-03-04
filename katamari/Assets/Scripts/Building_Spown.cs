using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Text;

public class Building_Spown : MonoBehaviour
{
    private string stage_number="02";

    private TextAsset stage_text;//ステージ固有のテキストファイルを読み込む
    //private string text_line;//テキストのデータをstring型に直す
    private string[] text_line;//stage_dataを改行で分けたものを格納する
    private string[] stage_data_text;//kaigyou_splitをコンマで分けたものを格納する
    void Start()
    {
        stage_text = Resources.Load("text/stage_data"+stage_number) as TextAsset;
        text_line = stage_text.text.Split(char.Parse("\n"));
        for (int i = 0; i < text_line.Length; i++) 
        {
            stage_data_text = text_line[i].Split(char.Parse(","));
            Vector3 Spown_Position = new Vector3(float.Parse(stage_data_text[1]), float.Parse(stage_data_text[2]), float.Parse(stage_data_text[3]));
            string Spown_Name = GameObject.Find("TokenDataBase").GetComponent<TokenDataBase>().getObject_DataBase(int.Parse(stage_data_text[0])).Object_Name;
            GameObject Spown_Object = (GameObject)Resources.Load("prefabs/" + Spown_Name);
            Instantiate(Spown_Object, Spown_Position, Spown_Object.transform.rotation);
        }
    }

    public void setStageNumber()
    {

    }
}
