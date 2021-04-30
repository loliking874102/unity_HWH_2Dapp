using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpManager : MonoBehaviour
{
    [Header("血條")]
    public Image Hpimage ;
    /// <summary>
    /// 血條與血量MAX更新血條
    /// </summary>
    /// <param name="hp">血量</param>
    /// <param name="hpMax">血量MAX</param>
    public void UpdateHPdata(float hp , float hpMax)
    {
        //血量.填滿數值 = 當前血量/血量最大值
        Hpimage.fillAmount = hp / hpMax;    
    }
}
