
using UnityEngine;

public class LevelChnger : MonoBehaviour
{
    public Animator animator;


    

    public void FadeToLevel (int levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }
}
