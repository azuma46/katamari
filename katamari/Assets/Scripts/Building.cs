using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : Token {

    public int Number;
    Object_Data building_data;

    void Start () {
        building_data = GameObject.Find("TokenDataBase").GetComponent<TokenDataBase>().getObject_DataBase(Number);
        setObject_Data(building_data);
    }
    
    void Update () {
        
    }
}