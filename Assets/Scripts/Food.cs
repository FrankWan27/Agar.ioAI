﻿using UnityEngine;
using UnityEditor;
using System;

public class Food : MonoBehaviour
{
    public float x;
    public float y;
    public Tuple<int, int> coord;
    public void Awake()
    {
        float randX = UnityEngine.Random.Range(-Utils.GAME_WIDTH / 2, Utils.GAME_WIDTH / 2);
        float randY = UnityEngine.Random.Range(-Utils.GAME_HEIGHT / 2, Utils.GAME_HEIGHT / 2);
        Vector3 randLoc = new Vector3(randX, randY, 0);

        GetComponent<SpriteRenderer>().color = Utils.RandomColor();
        transform.position = randLoc;
        x = randX;
        y = randY;

        coord = Utils.GetCoordinate(randX, randY);
    }
}