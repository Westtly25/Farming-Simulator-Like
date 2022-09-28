using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

[RequireComponent(typeof(Rigidbody2D),
                  typeof(GenerateGUID),
                  typeof(SortingGroup))]
public class Character : MonoBehaviour
{
    [Header("Cached Components")]
    [SerializeField] private Rigidbody2D rgb2D;
    [SerializeField] private GenerateGUID generateGUID;

    [Header("Classes")]
    [SerializeField] private IMovement movement;
    [SerializeField] private DefaultInputActions inputActions;

    public virtual void Initialize()
    {
        SetComponentsData();

        movement = new Movement(2.5f);
        inputActions = new DefaultInputActions();
    }

    private void SetComponentsData()
    {
        rgb2D ??= GetComponent<Rigidbody2D>();
        generateGUID ??= GetComponent<GenerateGUID>();
    }

    private void Awake()
    {
        Initialize();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }


    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (!inputActions.Player.Move.IsPressed()) { return; }

        Vector2 direction = inputActions.Player.Move.ReadValue<Vector2>();
        rgb2D.MovePosition(rgb2D.position + movement.GetDirection(direction));
    }
}
