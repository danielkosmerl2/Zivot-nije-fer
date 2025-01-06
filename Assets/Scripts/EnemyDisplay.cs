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

    public List<EnemyScriptable> enemies = new List<EnemyScriptable>();

    public Image artworkImage;

    public TextMeshProUGUI pbText;
    public TextMeshProUGUI rbText;
    public TextMeshProUGUI tbText;


    // Start is called before the first frame update
    void Start()
    {
        
        artworkImage.sprite = upro_lab.artwork;
        pbText.text = upro_lab.pb.ToString() + " PB";
        rbText.text = upro_lab.rb.ToString() + " RB";
        tbText.text = upro_lab.tb.ToString() + " TB";
        
        /*
        enemies.Add(upro_lab);
        enemies.Add(diglog_lab);
        enemies.Add(matan1_mi);

        spawnEnemy(0);
        */
    }

    /*
    public void spawnEnemy(int enemyIndex)
    {
        artworkImage.sprite = enemies[enemyIndex].artwork;
        pbText.text = enemies[enemyIndex].pb.ToString() + " PB";
        rbText.text = enemies[enemyIndex].rb.ToString() + " RB";
        tbText.text = enemies[enemyIndex].tb.ToString() + " TB";
    }
    */

    
    public void changeEnemyDiglog()
    {
        artworkImage.sprite = diglog_lab.artwork;
        pbText.text = diglog_lab.pb.ToString() + " PB"; ;
        rbText.text = diglog_lab.rb.ToString() + " RB"; ;
        tbText.text = diglog_lab.tb.ToString() + " TB"; ;
    }
    public void changeEnemyMatan()
    {
        artworkImage.sprite = matan1_mi.artwork;
        pbText.text = matan1_mi.pb.ToString() + " PB";
        rbText.text = matan1_mi.rb.ToString() + " RB";
        tbText.text = matan1_mi.tb.ToString() + " TB"; ;
    }
    public void changeEnemyUpro()
    {
        artworkImage.sprite = upro_lab.artwork;
        pbText.text = upro_lab.pb.ToString() + " PB";
        rbText.text = upro_lab.rb.ToString() + " RB";
        tbText.text = upro_lab.tb.ToString() + " TB"; ;
    }
    
}
