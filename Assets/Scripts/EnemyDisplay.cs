using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDisplay : MonoBehaviour
{

    public EnemyScriptable upro_lab;
    public EnemyScriptable diglog_lab;
    public EnemyScriptable matan1_mi;
    public EnemyScriptable upro_mi;
    public EnemyScriptable vjekom_pitch;
    public EnemyScriptable oe_lab;
    public EnemyScriptable oop_lab;
    public EnemyScriptable matan2_mi;
    public EnemyScriptable oe_mi;
    public EnemyScriptable fiz_lab;


    public Enemy enemy;

    public List<EnemyScriptable> enemies = new List<EnemyScriptable>();

    public Image artworkImage;
    public TextMeshProUGUI pbText;
    public TextMeshProUGUI rbText;
    public TextMeshProUGUI tbText;
    public TextMeshProUGUI enemyNameText;
    public TextMeshProUGUI ectsText;


    // Start is called before the first frame update
    void Start()
    {
        /*
        artworkImage.sprite = upro_lab.artwork;
        pbText.text = upro_lab.pb.ToString() + " PB";
        rbText.text = upro_lab.rb.ToString() + " RB";
        tbText.text = upro_lab.tb.ToString() + " TB";
        enemyNameText.text = upro_lab.enemyName + ":";
        ectsText.text = upro_lab.ects.ToString() + " ECTS";
        */
        
        enemies.Add(upro_lab);
        enemies.Add(diglog_lab);
        enemies.Add(matan1_mi);
        enemies.Add(upro_mi);
        enemies.Add(vjekom_pitch);
        enemies.Add(oe_lab);
        enemies.Add(oop_lab);
        enemies.Add(matan2_mi);
        enemies.Add(oe_mi);
        enemies.Add(fiz_lab);
        spawnEnemy(0);
    }

    
    public void spawnEnemy(int enemyIndex)
    {
        artworkImage.sprite = enemies[enemyIndex].artwork;
        pbText.text = enemies[enemyIndex].pb.ToString() + " PB";
        rbText.text = enemies[enemyIndex].rb.ToString() + " RB";
        tbText.text = enemies[enemyIndex].tb.ToString() + " TB";
        enemyNameText.text = enemies[enemyIndex].enemyName + ":";
        ectsText.text = enemies[enemyIndex].ects.ToString() + " ECTS";

        enemy.ECTS = enemies[enemyIndex].ects;
        enemy.TB = enemies[enemyIndex].tb;
        enemy.RB = enemies[enemyIndex].rb;
        enemy.PB = enemies[enemyIndex].pb;
        enemy.predmet = enemies[enemyIndex].enemyName;
        enemy.spawnHealthBars();
    }

    
    public void changeEnemyDiglog()
    {
        /*
        artworkImage.sprite = diglog_lab.artwork;
        pbText.text = diglog_lab.pb.ToString() + " PB";
        rbText.text = diglog_lab.rb.ToString() + " RB";
        tbText.text = diglog_lab.tb.ToString() + " TB";
        enemyNameText.text = diglog_lab.enemyName + ":";
        ectsText.text = diglog_lab.ects.ToString() + " ECTS";
        */
        spawnEnemy(1);
    }
    public void changeEnemyMatan()
    {
        /*
        artworkImage.sprite = matan1_mi.artwork;
        pbText.text = matan1_mi.pb.ToString() + " PB";
        rbText.text = matan1_mi.rb.ToString() + " RB";
        tbText.text = matan1_mi.tb.ToString() + " TB";
        enemyNameText.text = matan1_mi.enemyName + ":";
        ectsText.text = matan1_mi.ects.ToString() + " ECTS";
        */
        spawnEnemy(2);
    }
    public void changeEnemyUpro()
    {
        /*
        artworkImage.sprite = upro_lab.artwork;
        pbText.text = upro_lab.pb.ToString() + " PB";
        rbText.text = upro_lab.rb.ToString() + " RB";
        tbText.text = upro_lab.tb.ToString() + " TB";
        enemyNameText.text = upro_lab.enemyName + ":";
        ectsText.text = upro_lab.ects.ToString() + " ECTS";
        */
        spawnEnemy(0);
    }
}
    
