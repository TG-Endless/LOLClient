﻿public delegate void WarningResult();
public class WarningModel
{
    public WarningResult result;
    public string value;
    public float delay;

    public WarningModel(string value, WarningResult relust = null,float delay= -1)
    {
        this.value = value;
        this.result = relust;
        this.delay = delay;
    }

}