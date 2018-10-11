using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
using System;
public class GameManager : BaseMnager
{

    private UIPlaces place;

    protected Dictionary<GameFabs, string> GamefabPathDict;//存储所有面板Prefab的路径
    public GameManager(GameFacade facade) : base(facade)
    {
        ParseUIPanelTypeJson();
       


    }

    public override void OnInit()
    {
        base.OnInit();
        place = new UIPlaces();
        place.LoadPlace(DictionaryExtension.TryGet<GameFabs, string>(GamefabPathDict, GameFabs.Cube));
    }




    private void ParseUIPanelTypeJson()
    {
        GamefabPathDict = new Dictionary<GameFabs, string>();

        JsonData data;

        data = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Resources/Texts/Prefabsdath.Json.txt"));

        for (int i = 0; i < data.Count; i++)
        {
            string[] temp = data[i][0].ToString().Split('/');

            GameFabs types = (GameFabs)Enum.Parse(typeof(GameFabs), temp[1]);

            GamefabPathDict.Add(types, data[i][0].ToString());
        }
    }

    

}
