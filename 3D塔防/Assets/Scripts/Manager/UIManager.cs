using System.Collections;
using System.Collections.Generic;


public class UIManager : BaseMnager
{

    private Dictionary<UIFabs, string> panelPathDict;//存储所有面板Prefab的路径

    //private UIPanelType panelTypeToPush = UIPanelType.None;

    public UIManager(GameFacade facade) : base(facade)
    {
        //ParseUIPanelTypeJson();
    }




    //private void ParseUIPanelTypeJson()
    //{
    //    panelPathDict = new Dictionary<UIFabs, string>();

    //    JsonData data;

    //    data = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Resources/Texts/Prefabsdath.Json.txt"));

    //    for(int i=0;i<data.Count;i++)
    //    {
    //        string[] temp = data[i][0].ToString().Split('/');

    //        UIFabs types= (UIFabs)Enum.Parse(typeof(UIFabs), temp[2]);

    //        panelPathDict.Add(types, data[i][0].ToString());
    //    }



    //}

}
