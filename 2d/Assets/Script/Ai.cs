using UnityEngine;
public class Ai : MonoBehaviour
{
    [Header("追蹤範圍"), Range(0, 8)]
    public float rangeTrack = 2;
    private Transform player;
    
    private void Start()
    {
        //搜尋玩家座標並取得物件(物件名稱).變形
        player = GameObject.Find("主角").transform;
    }
    
    //繪製圖示事件:輔助開發
    private void OnDrawGizmos()
    {   
        //繪製顏色
        Gizmos.color = new Color(0, 0, 3, 0.35f);
        //繪製形狀(中心點,半徑)
        Gizmos.DrawSphere(transform.position, rangeTrack);
    }
    private void Update()
    {
        Track();
    }
    /// <summary>
    /// 追蹤玩家
    /// </summary>
    private void Track()
    {
                    //距離=三維向量的距離(a,b)
        float dis = Vector3.Distance(transform.position, player.position);
        print("距離="+dis);
    }
}
