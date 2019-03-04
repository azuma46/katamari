using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public struct Object_Data
{
    public int Object_Number;
    public string Object_Name;
    public int Object_Level;
    public float Object_EXP;
    public float Add_Radius;
}

public class Token:MonoBehaviour
{
    private Object_Data object_Data;

    public void setObject_Data(Object_Data data)
    {
        object_Data = data;
    }
    public Object_Data getObject_Data()
    {
        return object_Data;
    }

    public void setObject_Number(int number)
    {
        object_Data.Object_Number = number;
    }
    public int getObject_Number()
    {
        return object_Data.Object_Number;
    }

    public void setObject_Name(string name)
    {
        object_Data.Object_Name = name;
    }
    public string getObject_Name()
    {
        return object_Data.Object_Name;
    }

    public void setObject_Level(int level)
    {
        object_Data.Object_Level = level;
    }
    public int getObject_Level()
    {
        return object_Data.Object_Level;
    }

    public void setObject_EXP(float exp)
    {
        object_Data.Object_EXP = exp;
    }
    public float getObject_EXP()
    {
        return object_Data.Object_EXP;
    }

    public void setAdd_Radius(float radius)
    {
        object_Data.Add_Radius = radius;
    }
    public float getAdd_Radius()
    {
        return object_Data.Add_Radius;
    }
}
