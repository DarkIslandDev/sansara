using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Generator : MonoBehaviour
{
    public Tilemap wallTilemap;
    public Tilemap floorTilemap;
    public Tile wall;
    public Tile floor;

    private bool[,] isContainTile = new bool[11, 11];

    void Start()
    {
        StartCoroutine(Generate());
        // SetRoom();
        // SetWalls();
        // SetFloor(floor);
    }

    private IEnumerator Generate()
    {
        for (int i = 0; i < 8; i++)
        {
            yield return new WaitForSeconds(0.02f);

            wallTilemap.SetTile(new Vector3Int(i, 9, 0), wall);
            wallTilemap.SetTile(new Vector3Int(0, 8, 0), wall);
            wallTilemap.SetTile(new Vector3Int(7, 8, 0), wall);

            wallTilemap.SetTile(new Vector3Int(i, 0, 0), wall);
            wallTilemap.SetTile(new Vector3Int(0, 1, 0), wall);
            wallTilemap.SetTile(new Vector3Int(7, 1, 0), wall);

            wallTilemap.SetTile(new Vector3Int(-1, i + 1, 0), wall);
            wallTilemap.SetTile(new Vector3Int(8, i + 1, 0), wall);
        }
    }
    
    

    // private void SetFloor(Tile floor)
    // {
    //     for (int i = 0; i < 10; i++)
    //     {
    //         for (int y = 1; y < 11; y++)
    //         {
    //             floorTilemap.SetTile(new Vector3Int(i + 1, y, 0), floor);
    //         }
    //     }
    // }

    // private void SetWalls()
    // {
    //     // var road = roads[Random.Range(0, roads.Length)];
    //     for (int i = 0; i < 11; i++)
    //     {
    //         wallTilemap.SetTile(new Vector3Int(i, 11, 0), wall);
    //         wallTilemap.SetTile(new Vector3Int(11, -i + 11, 0), wall);
    //         wallTilemap.SetTile(new Vector3Int(-i + 11, 0, 0), wall);
    //         wallTilemap.SetTile(new Vector3Int(0, i, 0), wall);
    //     }
    //
    //     for (int i = 1; i < 11; i++)
    //     {
    //         wallTilemap.SetTile(new Vector3Int(6, i, 0), wall);
    //         isContainTile[6, i] = true;
    //     }
    //
    //     for (int i = 6; i < 11; i++)
    //     {
    //         wallTilemap.SetTile(new Vector3Int(i, 6, 0), wall);
    //         isContainTile[i, 6] = true;
    //     }
    // }
}