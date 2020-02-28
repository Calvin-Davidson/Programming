using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData {
    private Text healtText;

    public PlayerData()
    {
        healtText = GameObject.Find("HealtText").GetComponent<Text>();
    }

    private int _health = 100;


    public int getHealth()
    {
        return this._health;
    }

    public void setHealth(int value)
    {
        this._health = value;
        healtText.text = "Health: " + _health;

        if (_health <= 0)
        {
            Debug.Log("ik ben dood :(");
        }
    }
}
