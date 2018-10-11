using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlaces
{

    public int[][] maps;
    public int hei;
    public int wid;

    public UIPlaces()
    {
        TextAsset ta = Resources.Load<TextAsset>("Texts/Map");
    
        string[] temp= ta.text.ToString().Split(',');
       
        hei = int.Parse(temp[0]);
        wid = int.Parse(temp[1]);
        maps = new int[hei][];
        for(int i=0;i< hei; i++)
        {
            maps[i] = new int[wid];
        }
        int num = 2;
        for (int i=0;i< hei; i++)
        {
            for(int j=0;j< wid;j++)
            {
                maps[i][j] = int.Parse(temp[num]);
                num++;
            }
        }
    }

    public void LoadPlace(string dath)
    {
        
        GameObject obj = Resources.Load<GameObject>(dath);
        Debug.Log(obj.name);
        for (int i=0;i<hei;i++)
        {
            for(int j=0;j<wid;j++)
            {
                if (maps[i][j] == 0)
                {
                    GameObject.Instantiate(obj, new Vector3(i,0,j), Quaternion.identity);
                }
            }
        }
    }






}
