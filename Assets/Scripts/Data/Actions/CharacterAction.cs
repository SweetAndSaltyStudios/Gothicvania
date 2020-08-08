using UnityEngine;

namespace SweetAndSaltyStudios
{
    [CreateAssetMenu(fileName = "New Character Action", menuName = "Sweet & Salty Studios/New Character Action")]
    public class CharacterAction : ScriptableObject
	{
        #region VARIABLES

        [SerializeField] private ACTION_TYPE type = default;
        [SerializeField] private bool waitUntilOver = default;
        [SerializeField] private AnimationClip animationClip = default;

        #endregion VARIABLES

        #region PROPERTIES

        public ACTION_TYPE Type { get { return type; } }
        public bool WaitUntilOver { get { return waitUntilOver; } }
        public AnimationClip AnimationClip { get { return animationClip; } }

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        #endregion CUSTOM_FUNCTIONS
    }
}