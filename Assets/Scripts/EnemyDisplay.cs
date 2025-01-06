using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDisplay : MonoBehaviour
{

    public EnemyScriptable upro_lab;
    public EnemyScriptable diglog_lab;
    public EnemyScriptable matan1_mi;

    public Image artworkImage;


    // Start is called before the first frame update
    void Start()
    {
        artworkImage.sprite = upro_lab.artwork;
    }

    public void changeEnemyDiglog()
    {
        artworkImage.sprite = diglog_lab.artwork;
    }
    public void changeEnemyMatan()
    {
        artworkImage.sprite = matan1_mi.artwork;
    }
    public void changeEnemyUpro()
    {
        artworkImage.sprite = upro_lab.artwork;
    }
}
