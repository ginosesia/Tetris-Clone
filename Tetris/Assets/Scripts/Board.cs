using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{

    public Tilemap tileMap { get; private set; }
    public TetrominoData[] tetrominoes;



    private void Awake()
    {
        this.tileMap = GetComponentInChildren<Tilemap>();

        for (int i = 0; i < this.tetrominoes.Length; i ++)
        {
            this.tetrominoes[i].Initialize();
        }

    }

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        int random = Random.Range(0, this.tetrominoes.Length);
        TetrominoData data = this.tetrominoes[random];
    }


    public void SetPiece()
    {

    }


}

