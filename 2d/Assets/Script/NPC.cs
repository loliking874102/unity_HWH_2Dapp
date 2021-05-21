using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("商店介面")]
    public GameObject objShop;
    /// <summary>
    /// 玩家選取的武器
    /// 0 短劍 1元
    /// 1 長劍 2元
    /// 2 聖劍 3元
    /// </summary>
    public int indexweapon;    //選取哪把武器
    /// <summary>
    /// 武器價格
    /// </summary>
    private int[] priceWeapon = { 1, 2, 3 };
    /// <summary>
    /// 玩家武器
    /// </summary>
    public GameObject[] objweapon;
    private float[] attackweapon = {10,50,100 } ;
    private Player player;
    #region 方法
    /// <summary>
    /// 開啟商店介面
    /// </summary>
    public void OpenShop()
    {
        objShop.SetActive(true);
    }
    /// <summary>
    /// 關閉商店介面
    /// </summary>
    public void CloseShop()
    {
        objShop.SetActive(false);
    }
    /// <summary>
    /// 玩家選的武器
    /// </summary>
    public void ChooseWeapon(int choose)
    {
        indexweapon = choose; 
    }
    /// <summary>
    /// 購買武器
    /// 判斷玩家金幣是否足夠
    /// 購買後扣除金幣更新金幣介面
    /// 顯示武器在玩家身上
    /// </summary>
    public void Buy()
    {
        if (player.coin >= priceWeapon[indexweapon])
        {
            player.coin -= priceWeapon[indexweapon];
            player.GetCoin.text = "金幣" + player.coin;
            player.attackweapon = attackweapon[indexweapon];
            //武器隱藏
            for (int i = 0; i < objweapon.Length; i++) 
            {
                objweapon[i].SetActive(false);
            }
            objweapon[indexweapon].SetActive(true);
            
           

        }
    }
    #endregion
    private void Start()
    {
        player = GameObject.Find("主角").GetComponent<Player>();
    }
}
