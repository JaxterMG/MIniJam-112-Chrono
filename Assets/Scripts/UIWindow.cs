using UnityEngine;

namespace UI
{
    public  class UIWindow : MonoBehaviour
    {
        protected Animator animator;
        protected bool animationStopped = false;
        protected virtual void Awake()
        {
            animator = GetComponent<Animator>();
            ShowWindow("UIHolderAppear");
        }

        protected virtual void OnAnimationStopped()
        {
            animationStopped = true;
        }


        public virtual void ShowWindow(string animationName)
        {
            animator.Play(animationName);
        }

        public virtual void HideWindow(string animationName)
        {
            animator.Play(animationName);
        }
    }
}