﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFacade : MonoBehaviour {

    private static GameFacade _instance;
    public static GameFacade Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.Find("GameFacade").GetComponent<GameFacade>();
            }
            return _instance;
        }
    }
    private UIManager uiMng;
    private GameManager gameMng;




    // Use this for initialization
    void Start () {
        uiMng = new UIManager(this);
        gameMng = new GameManager(this);



        gameMng.OnInit();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
