using UnityEngine;

namespace SweetAndSaltyStudios
{
    public class Player : MonoBehaviour
	{
        #region VARIABLES

        private const string HORIZONTAL_AXIS_NAME = "Horizontal";
        private const string VERTICAL_AXOS_NAME = "Vertical";

        [Space]
        [Header("Settings")]
        [SerializeField] [Range(0, 100)] private float movementSpeed = 5;
        [SerializeField] private KeyCode jumpKey = KeyCode.Space;
        [SerializeField] private KeyCode attackKey = KeyCode.E;
        private bool isGrounded = default;

        [Space]
        [Header("References")]
        [SerializeField] private ActionController actionController = default;
        [SerializeField] private Rigidbody2D rb2D = default;

        private Vector2 movementDirection;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Start()
        {
            actionController.StartAction(ACTION_TYPE.IDLE);
        }

        private void Update()
        {
            HandleInputs();
            HandleFaceDirection();

            shouldMove = movementDirection.x != 0;
        }

        bool shouldMove;

        private void FixedUpdate()
        {
            rb2D.velocity = shouldMove ? 
                new Vector2(movementDirection.x * movementSpeed, rb2D.velocity.y) :
                new Vector2(0, rb2D.velocity.y);
        }

        private void OnCollisionEnter2D(Collision2D collision2D)
        {
            switch(collision2D.gameObject.layer)
            {
                case 8:
                    isGrounded = true;
                    break;

                default:

                    break;
            }
        }

        private void OnCollisionExit2D(Collision2D collision2D)
        {
            switch(collision2D.gameObject.layer)
            {
                case 8:
                    isGrounded = false;
                    break;

                default:

                    break;
            }
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        private void HandleFaceDirection()
        {
            if(movementDirection.x != 0 && transform.localScale.x != movementDirection.x)
            {
                transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
            }
        }

        private void HandleInputs()
        {
            movementDirection.x = Input.GetAxis/*Raw*/(HORIZONTAL_AXIS_NAME);
            movementDirection.y = Input.GetAxis/*Raw*/(VERTICAL_AXOS_NAME);

            if(Input.GetKeyDown(KeyCode.E))
            {
                actionController.StartAction(ACTION_TYPE.CASTING_1);
            }
        }

        #endregion CUSTOM_FUNCTIONS
    }
}