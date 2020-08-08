using System;
using UnityEngine;

namespace SweetAndSaltyStudios
{
    [CreateAssetMenu(fileName = "New Sprite Animation", menuName = "Sweet & Salty Studios/New Sprite Animation")]
    public class AnimationClip : ScriptableObject
    {
        #region VARIABLES

        [SerializeField] private string name = default;
        [SerializeField] private Sprite[] sprites = default;
        [SerializeField] private bool isLooping = false;
        [SerializeField] private float animationRate = 0.02f;

        #endregion VARIABLES

        #region PROPERTIES

        public Sprite[] Sprites { get { return sprites; } }
        public bool IsLooping { get { return isLooping; } }
        public float AniamtionRate { get { return animationRate; } }

        #endregion PROPERTIES

        #region CUSTOM_FUNCTIONS

        #endregion CUSTOM_FUNCTIONS
    }
}