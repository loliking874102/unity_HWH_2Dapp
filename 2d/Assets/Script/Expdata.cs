using UnityEngine;
[CreateAssetMenu(fileName ="經驗值資料",menuName ="LOLI/經驗值資料")]
public class Expdata : ScriptableObject
{
    //陣列
    //語法:在類型後面加上一對中括號
    //陣列用法:儲存多筆相同資料
    [Header("每個經驗值等級的需求")]
    public float[] exp;
}
