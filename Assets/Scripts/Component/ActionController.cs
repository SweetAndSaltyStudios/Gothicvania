using UnityEngine;

namespace SweetAndSaltyStudios
{
    public class ActionController : MonoBehaviour
    {
        #region VARIABLES

        [SerializeField] private CharacterAction[] characterActions = default;
        [SerializeField] private SpriteAnimator spriteAnimator = default;

        private CharacterAction currentAction = default;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        public void StartAction(ACTION_TYPE type)
        {
            currentAction = GetCharacterAction(type);

            if(currentAction == null) return;
            if(spriteAnimator == null) return;
            if(currentAction.AnimationClip == null) return;

            spriteAnimator.PlayAnimation(currentAction.AnimationClip);
        }

        private void StopAction(CharacterAction characterAction)
        {
            if(characterAction == null) return;
            if(characterAction.WaitUntilOver == true) return;

        }

        private CharacterAction GetCharacterAction(ACTION_TYPE type)
        {
            for(var i = 0; i < characterActions.Length; i++)
            {
                if(characterActions[i].Type == type) return characterActions[i];
            }

            return null;
        }

        #endregion CUSTOM_FUNCTIONS
    }
}