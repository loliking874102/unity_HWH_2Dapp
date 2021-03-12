using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("等級"),Tooltip("調整角色等級")]
    public int lvl=1;
    [Header("速度"),Range(0,10),Tooltip("調整角色速度")]
    public float speed = 10.5f;
    [Header("攻擊"), Tooltip("調整角色攻擊傷害")]
    public float attack = 10;
    [Header("死亡"),Tooltip("角色是否死亡")]
    public bool Isdead = false;
    [Header("名子"),Tooltip("角色名稱")]
    public string cName = "貓咪";
    [Header("金幣"),Tooltip("獲得金幣數量")]
    public int coin = 0;
    
}
