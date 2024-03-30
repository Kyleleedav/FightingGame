using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce;
    public float gravityScale;
    public int playerNumber;
    public int characterBaseAirMobilityValue;
    public int currentAirMobilityValue;
    public int attackStrength;
    public bool isStanding;

    [System.Serializable]
    public class stances
    {
        public bool standing;
        public bool crouching;
        public bool airborne;
        public bool knockedDown;
        public bool sideStepRight;
        public bool sideStepLeft;
    }
    public stances[] currentStance;

    public GameObject pushbox;
    public GameObject rightPunchHitbox;
    public GameObject leftPunchHitbox;
    public GameObject rightKickHitbox;
    public GameObject leftKickHitbox;
    public GameObject characterHurtbox;
    public GameObject[] opponents;
    public Collider[] attackMove;
    public bool lightLeftPunch = false;
    public bool MediumRightPunch = false;
    public bool HeavyLeftRightPunch = false;
    public bool lightLeftKick = false;
    public bool MediumRightKick = false;
    public bool HeavyLeftRightKick = false;

    private float currentMoveStrength;
    private Vector3 moveDirection;
    private CharacterController controller;

    [Range(1, 10)]
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2.5f;
    public float jumpVelocity = 30f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        /*
        ----------------------Development Note-----------------------------
        At the start of the round the game needs to detect:
        1): How many players are in the current match at the start of the match.
        2): How many cahracters are populating the scene.
        3): Who are who's enemy
        Needs more work!!!
        -------------------------------------------------------------------
        */
        if (playerNumber == 1)
        {
            Debug.Log("This is player 1");
            //opponents = GameObject.FindGameObjectsWithTag("Player2");
            Debug.Log("Found Player 2");
        }

        else
        {
            Debug.Log("This is player 2");
        }
        /*
         * 
        //opponent = GameObject.FindGameObjectsWithTag("Player2")
        */

        controller = GetComponent<CharacterController>();
        currentAirMobilityValue = characterBaseAirMobilityValue;

        currentStance[0].standing = true;

    }

    // Update is called once per frame
    void Update()
    {
        //Inputs
        //float x = Input.GetAxisRaw("Horizontal") * movementSpeed;

        //Moving
        //Vector3 movPos = transform.right * x;
        //Vector3 newMovePos = new Vector3(movPos.x, rb.velocity.y, movPos.z * 0f);

        //rb.velocity = newMovePos;

        /*if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }

        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }*/

        /*
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, 0f, Input.GetAxis("Vertical") * 0);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveDirection.y = jumpForce;
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
        controller.Move(moveDirection * Time.deltaTime);
        */

        /*
        ----------------------Development Note-----------------------------
        Below are the attack listsThis is the case for counter hits....Needs more work!!!
        -------------------------------------------------------------------
        */
        if (Input.GetKeyDown(KeyCode.O))
        {
            LaunchAttack(attackMove[0]);

            currentMoveStrength = attackMove[0].GetComponent<AttackMoveScript>().moveDamage;
            Debug.Log("This move is " + currentMoveStrength + " Strong");
            Debug.Log("Light/Left Punch");
            rightPunchHitbox.SetActive(true);
            StartCoroutine(EnableHurtbox());
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            LaunchAttack(attackMove[1]);
            currentMoveStrength = attackMove[1].GetComponent<AttackMoveScript>().moveDamage;
            Debug.Log("This move is " + currentMoveStrength + " Strong");
            Debug.Log("GUN FLAME!!!!!");
            leftPunchHitbox.SetActive(true);
            StartCoroutine(EnableHurtbox());
        }

        if (Input.GetKeyDown(KeyCode.K) && Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Heavy/Left + Right Punch");
            StartCoroutine(EnableHurtbox());
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Right Kick");
            StartCoroutine(EnableHurtbox());
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Left Kick");
            StartCoroutine(EnableHurtbox());
        }
    }

    private void LaunchAttack(Collider col)
    {
        Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("Hurtbox"));
        foreach (Collider c in cols)
        {
            if (c.transform.parent.parent == transform)
            continue;

            float finalDamageSent = 0;
            switch (c.name)

            /*
            ----------------------Development Note-----------------------------
            The switch statment below is currently mapped to detecting hits on
            body parts. I has to be changed to hits on states such as normal
            hits, counter hits, reversals, ect
            -------------------------------------------------------------------
            */
            //switch (c.transform.parent.parent.GetComponent<CharacterController>())
            {
                /*
                    ----------------------Development Note-----------------------------
                    This is the case for normal hits....Needs more work!!!
                    -------------------------------------------------------------------
                */
                case "CharacterHurtbox":
                    Debug.Log("Hit the hurtbox");
                    finalDamageSent = currentMoveStrength * 1.0f;
                    Debug.Log("Normalhit!!! Deal damage of" + finalDamageSent);
                break;

                /*
                    ----------------------Development Note-----------------------------
                    This is the case for counter hits....Needs more work!!!
                    -------------------------------------------------------------------
                */
                case "Torso":
                    finalDamageSent = currentMoveStrength * 1.25f;
                    Debug.Log("Counterhit!!! Deal damage of" + finalDamageSent);
                break;

                Debug.Log("Unable to identify body part, make sure the name matches the switch case");
                break;
            }

            c.SendMessageUpwards("TakeDamage", finalDamageSent);
        }
        
    }

    /*
    ----------------------Development Note-----------------------------
    The code below needs a permanent fix
    -------------------------------------------------------------------
    */
    IEnumerator EnableHurtbox()
    {
        characterHurtbox.SetActive(true);
        yield return new WaitForSeconds(1);
        characterHurtbox.SetActive(false);
        //This needs a permanent fix.
        rightPunchHitbox.SetActive(false);
        leftPunchHitbox.SetActive(false);
    }
}
