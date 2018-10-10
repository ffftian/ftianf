using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMnager{

    protected GameFacade facade;
    public BaseMnager(GameFacade facade)
    {
        this.facade = facade;
    }
    public virtual void OnInit() { }
    public virtual void Update() { }
    public virtual void OnDestroy() { }
}
