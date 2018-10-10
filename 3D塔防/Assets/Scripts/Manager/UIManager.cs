using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using LitJson;
using System;

public class UIManager : BaseMnager
{

    private Dictionary<string, string> panelPathDict;//存储所有面板Prefab的路径

    //private UIPanelType panelTypeToPush = UIPanelType.None;

    public UIManager(GameFacade facade) : base(facade)
    {
        ParseUIPanelTypeJson();
    }




    private void ParseUIPanelTypeJson()
    {
        panelPathDict = new Dictionary<string, string>();

        JsonData data;

        data = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Resources/Texts/Prefabsdath.Json.txt"));

        for(int i=0;i<data.Count;i++)
        {
            string[] temp = data[i][0].ToString().Split('/');
            panelPathDict.Add(temp[2], data[i][0].ToString());
        }



    }

}
