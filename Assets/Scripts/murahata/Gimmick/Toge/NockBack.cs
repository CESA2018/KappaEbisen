using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NockBack : GimmickBase {

    [SerializeField]
    private GameObject player;

    private Rigidbody rb;

    [SerializeField]
    private float pushPower;

    // Use this for initialization
    void Start()
    {
        rb = player.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //  コリジョン
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine("NockBackCol");
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("NockBackCol");
    }

    //  コルーチン
    private IEnumerator NockBackCol()
    {
        //  移動を固定
        player.GetComponent<PlayerMoving>().m_isMoved = false;
        //  ノックバックさせる
        yield return NockBackAction();

        //  少し待ってから移動可能に
        yield return new WaitForSeconds(0.3f);
        player.GetComponent<PlayerMoving>().m_isMoved = true;

    }

    //  ノックバック
    private IEnumerator NockBackAction()
    {
        rb.AddForce(transform.forward * pushPower);
        rb.AddForce(rb.transform.up * pushPower / 3);
        yield return null;
    }


}
