using UnityEngine;

public class GameManager : MonoBehaviour
{   
    [Header("黑毛")]
   public Transform B;
    [Header("黃毛")]
    public Transform Y;
    [Header("黑毛動畫元件")]
    public Animator aniB;
    [Header("黃毛動畫元件")]
    public Animator aniY;


    public void Attack()
    {
        print("攻擊");
        aniB.SetTrigger("攻擊觸發");
        aniY.SetTrigger("攻擊觸發");
    }

    public void PlayAnimation(string aniName)
    {
        print(aniName);
        aniB.SetTrigger(aniName);
        aniY.SetTrigger(aniName);




    }



}
