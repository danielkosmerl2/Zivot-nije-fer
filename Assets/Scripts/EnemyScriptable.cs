using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class EnemyScriptable : ScriptableObject
{
    public string enemyName;

    public int ects;
    public int pb;
    public int rb;
    public int tb;

    public Sprite artwork;
}
