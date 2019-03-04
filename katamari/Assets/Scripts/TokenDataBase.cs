using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

[DefaultExecutionOrder(-1)]
public class TokenDataBase:MonoBehaviour
{
    private TextAsset object_text;
    private string[] text_line;//一列ごとにデータを格納する
    private string[] object_data_str;
    private Object_Data[] object_data = new Object_Data[100];

    void Start()
    {
        object_text = Resources.Load("text/object_data") as TextAsset;
        text_line = object_text.text.Split(char.Parse("\n"));
        for(int i=0; i<text_line.Length; i++)
        {
            object_data_str = text_line[i].Split(char.Parse(","));
            object_data[i].Object_Number = int.Parse(object_data_str[0]);
            object_data[i].Object_Name = object_data_str[1];
            object_data[i].Object_Level = int.Parse(object_data_str[2]);
            object_data[i].Object_EXP = float.Parse(object_data_str[3]);
            object_data[i].Add_Radius = float.Parse(object_data_str[4]);
        }
    }
 
    public Object_Data getObject_DataBase(int number)
    {
        return object_data[number];
    }

}
