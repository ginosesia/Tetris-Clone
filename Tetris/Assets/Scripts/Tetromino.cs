using UnityEngine.Tilemaps;
using UnityEngine;

public enum Tetromino
{
    O,
    I,
    S,
    Z,
    L,
    T,
    J
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetrominoes;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }
}