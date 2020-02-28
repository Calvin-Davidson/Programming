using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClick : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerManager playerManager;
    void Start()
    {
        this.playerManager = GetComponent<PlayerManager>();
    }

  
    private void OnMouseDown()
    {
        this.playerManager.playerdata.setHealth(playerManager.playerdata.getHealth() - 10);
    }
}
