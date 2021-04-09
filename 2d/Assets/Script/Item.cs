using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [Header("掉落物品")]
    public GameObject prop;
    [Header("掉落機率"), Range(0f, 1f)]
    public float cent = 0.7f ;
    /// <summary>
    /// 隨機掉落
    /// </summary>
    public void Dropprop() 
    {
        //隨機.範圍(最小值,最大值)
        float f = Random.Range(0f, 1f);
        print("隨機值 =" + f);
    }
}
