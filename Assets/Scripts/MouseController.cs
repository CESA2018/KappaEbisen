using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MouseController : MonoBehaviour
{
    [SerializeField]
    private GameObject m_player;

    [SerializeField]
    private GameObject m_mirror;

    [SerializeField]
    private GameObject m_mirrorWorldPos;

    [SerializeField]
    private GameObject m_normalWorldPos;

    //  カメラ
    [SerializeField]
    private GameObject m_camera;

    //  鏡の世界にいるフラグ
    private bool m_inMirrorWorld;

    // Use this for initialization
    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        m_inMirrorWorld = false;
    }

    // Update is called once per frame
    void Update ()
    {

        if (Input.GetMouseButton(0))
        {
            //  画面を揺らす
            //m_camera.transform.DOShakePosition(1f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject mirror = GameObject.Find("Mirror");
            //  存在した
            if (mirror != null)
            {
                foreach (Transform child in mirror.transform)
                {
                    child.gameObject.layer = 1; //  Default
                }
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // プレイヤーから飛ばしたレイが衝突したオブジェクトの情報
            RaycastHit phit;
            // プレイヤーから向いている方向にレイを飛ばす
            if (Physics.Raycast(ray, out phit))
            {
                if (phit.transform.tag == ("Mirror"))
                {
                    // プレイヤーから衝突点へのベクトル
                    Vector3 f = phit.point - (m_player.transform.position + new Vector3(0, 1.34f, 0));
                    //Debug.DrawRay(m_player.transform.position + new Vector3(0, 1.34f, 0), f.normalized * 100, Color.red, 60);
                    // 衝突面の法線ベクトル
                    Vector3 n = phit.normal;
                    // 這いずりベクトル
                    //Vector3 w = f - (Vector3.Dot(f, n) * n);
                    // 反射ベクトル
                    Vector3 r = f - ((2.0f * Vector3.Dot(f, n)) * n);
                    // 鏡から飛ばしたレイが衝突したオブジェクトの情報
                    RaycastHit mhit;
                    // 衝突点から反射方向にレイを飛ばす
                    if (Physics.Raycast(phit.point, r.normalized, out mhit))
                    {
                        //Debug.DrawRay(phit.point, r.normalized * 100, Color.red, 60);
                        m_player.transform.position = mhit.point;
                        if (mhit.collider.tag == "Wall")
                        {
                            Vector3 v = -r.normalized * 0.5f;
                            m_player.transform.position += v;
                        }
                        else
                        {
                            Vector3 v = -r.normalized * 1.0f;
                            m_player.transform.position += v;
                        }

                        //  鏡の世界に移動する座標分ずらす
                        if (m_inMirrorWorld)
                        {
                            m_player.transform.position = m_normalWorldPos.transform.position;
                        }
                        else
                        {
                            m_player.transform.position = m_mirrorWorldPos.transform.position;
                        }

                        m_inMirrorWorld = !m_inMirrorWorld;

                    }
                }
            }
        }

        //  右クリックしたら鏡のタグを切り替える
        if (Input.GetMouseButtonDown(1))
        {
            // 現在存在する鏡のレイヤーをすべてIgnore Raycastに変える
            GameObject mirror = GameObject.Find("Mirror");
            //  存在した
            if (mirror != null)
            {
                foreach(Transform child in mirror.transform)
                {
                    child.gameObject.layer = 2; //  Ignore Raycast
                }
            }


            //m_mirror.layer = 2;   //  IgnoreRaycast
            //m_mirror.gameObject.tag = "Stage";
            //m_mirror.GetComponent<BoxCollider>().enabled = false;
        }
    }
}