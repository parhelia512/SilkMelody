using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStat", menuName = "ScriptableObjects/PlayerStat")]
public class PlayerStatSO : ScriptableObject
{
    [Header("Stat")]
    public int maxHp = 5;
    public int currentHp = 5;
    public int currentSilk = 0;
    public int maxSilk = 8;
    public int silkHeal = 3;
    public float damage = 1f;
    public float moveSpeed = 7f;
    public float jumpForce = 15f;
    public float dashForce = 15f;
    public int maxDashCount = 1;
    public float dashTime = 0.35f;
    public float enemyKnockbackPower = 2f;
    public float selfKnockbackPower = 1f;
    public float attackCooldown = 0.15f;
    public float parryWindow = 0.2f;
    public float parryCooldown = 1f;

    [Header("Inventory")]
    public int copperShard = 0;
    public int scaleShard = 0;

    [Header("Misc")]
    public float stunTime = 0.3f;
    public float iFrameTime = 3f;

    /** Note: If player get damaged, they will be stunned for a short time and has
     * i-frame for a long time.
     */
}