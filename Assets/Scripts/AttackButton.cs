using UnityEngine;

public class AttackButton : MonoBehaviour
{
    [SerializeField] private Animator animation;
    [SerializeField] private string[] attacks;
    private int attacknumber;
    public void Attack()
    {
        attacknumber = Random.Range(0, attacks.Length);
        animation.Play(attacks[attacknumber]);
    }
    
}
