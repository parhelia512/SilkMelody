using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BossRoomEntry : MonoBehaviour
{
    public GameObject doorObject;
    public AudioSource bossBGM;
    public CinemachineConfiner2D cameraConfiner;
    public PolygonCollider2D originalConfineArea;
    public PolygonCollider2D bossRoomConfineArea;
    public GameObject boss;
    private bool defeatedBoss;
    private bool activated;

    private void Start()
    {
        // Failsafe, make sure stuff are inactived
        doorObject.SetActive(false);
        bossBGM.Stop();
        boss.SetActive(false);
    }

    private void Update()
    {
        if (boss.GetComponent<Enemy>().isDead)
            DefeatBossFight();

        if (defeatedBoss)
            this.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!defeatedBoss && !activated)
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player)
            {
                doorObject.SetActive(true);
                cameraConfiner.m_BoundingShape2D = bossRoomConfineArea;
                bossBGM.Play();
                boss.SetActive(true);
                activated = true;
            }
        }
    }

    public void DefeatBossFight()
    {
        doorObject.SetActive(false);
        bossBGM.Stop();
        cameraConfiner.m_BoundingShape2D = originalConfineArea;
        defeatedBoss = true;
    }
}