using System;
using System.Collections;
using UnityEngine;

namespace SweetAndSaltyStudios
{
    public class SpriteAnimator : MonoBehaviour
    {
        #region VARIABLES

        [Space]
        [Header("References")]
        [SerializeField] private SpriteRenderer spriteRenderer = default;

        private Coroutine currentAnimationLoop = default;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        public void PlayAnimation(AnimationClip animationClip)
        {
            if(currentAnimationLoop != null)
            {
                StopCoroutine(currentAnimationLoop);
                currentAnimationLoop = null;
            }

            currentAnimationLoop = StartCoroutine(IPlayAnimation(animationClip));
        }

        private IEnumerator IPlayAnimation(AnimationClip animationClip)
        {
            var animationRate = animationClip.AniamtionRate;
            var isLooping = animationClip.IsLooping;
            var waitAnimationRate = new WaitForSeconds(animationRate);

            do
            {
                for(var i = 0; i < animationClip.Sprites.Length; i++)
                {
                    yield return waitAnimationRate;

                    spriteRenderer.sprite = animationClip.Sprites[i];
                }

            } while(isLooping);
        }

        #endregion CUSTOM_FUNCTIONS
    }
}