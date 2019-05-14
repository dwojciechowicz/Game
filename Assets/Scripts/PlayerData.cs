using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] position;
    //public List<GameObject> tiles;
    public PlayerData(PlayerMotion player, TileSpawning board)
    {
        position = new float[3];
        position[0] = player.rb.transform.position.x;
        position[1] = player.rb.transform.position.y;
        position[2] = player.rb.transform.position.z;
       // tiles = board.active;
    }
}
