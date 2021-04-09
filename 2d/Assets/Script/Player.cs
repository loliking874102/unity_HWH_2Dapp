using UnityEngine;
using UnityEngine.UI;
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
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("變形元件")]
    public Transform tra;
    [Header("動畫元件")]
    public Animator ani;
    [Header("偵測範圍")]
    public float rangeAttack = 2.5f;
    [Header("音效來源")]
    public AudioSource aud;
    [Header("攻擊音效")]
    public AudioClip soundAttack;
    //事件:繪製圖示
    private void OnDrawGizmos()
    {
        //指定圖示顏色
        Gizmos.color = new Color(1, 0, 0, 0.2f);
        //繪製圖示 球體(中心點,半徑)
        Gizmos.DrawSphere(transform.position, rangeAttack);
    }
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        print("移動");
        //獲取虛擬搖桿水平Horizontal
        float h = joystick.Horizontal;
        print("水平 =" + h);
        //獲取虛擬搖桿垂直Vertical
        float v = joystick.Vertical;
        print("垂直 =" + v);
        //變形元件.位移(h水平*速度*一楨,v垂直*速度*一楨,0)
        transform.Translate(h * speed * Time.deltaTime,v * speed * Time.deltaTime ,0);
        ani.SetFloat("水平", h);
        ani.SetFloat("垂直", v);
    }
    public void Att()
    {
        aud.PlayOneShot(soundAttack, 0.5f);
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, rangeAttack, -transform.up,  0,1 << 8);
        //如果 碰到物件.碰撞.tag為道具 碰到物件.碰撞.取得數值<數值名稱>.方法();
        if (hit && hit.collider.tag == "道具") hit.collider.GetComponent<Item>().Dropprop();
    }
    private void Hit()
    {

    }
    private void Dead()
    {

    }
    private void Start()
    {
          
    }
    private void Update()
    {
        //呼叫方法
        //名稱();
        Move();
    }
    //觸發事件:進入 兩個物件其中有一個勾選Is trigger
    [Header("吃金幣音效")]
    public AudioClip eatsound;
    [Header("金幣數量")]
    public Text GetCoin ;
    private int Coin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Coin++;
        print(collision.gameObject);
        aud.PlayOneShot(eatsound);
        Destroy(collision.gameObject);
        GetCoin.text = "金幣:" + Coin;
    }
}
