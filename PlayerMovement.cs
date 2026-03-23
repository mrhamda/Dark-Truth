using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 50;
    public float jumpHeight = 10;
    private Rigidbody2D rb2D;

    public GameObject groundDet;

    public GameObject deathMenu;
    public GameObject pauseMenu;
    public bool paused = false;

    public GameObject winMenu;

    public ParticleSystem landingParticlePrefab;

    public bool land;

    private int amountOfJumps;

    private bool doublejump;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        deathMenu.SetActive(false);

        paused = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (paused == false)
        {
            Move();

            Jump();

            Land();
        }

        Pause();
    }
    
    private void Land()
    {
        if (Physics2D.Raycast(groundDet.transform.position, -groundDet.transform.up, 0.5f).collider == null)
        {
            land = true;
        }
        if (Physics2D.Raycast(groundDet.transform.position, -groundDet.transform.up, 0.5f).collider != null && land == true)
        {
            Instantiate(landingParticlePrefab, groundDet.transform.position, Quaternion.identity);
            land = false;
            if (Physics2D.Raycast(groundDet.transform.position, -groundDet.transform.up, 0.5f).collider.tag == "Ground" || Physics2D.Raycast(groundDet.transform.position, -groundDet.transform.up, 0.5f).collider.tag == "MovingPlatform")
            {
                amountOfJumps = 2;
            }
        }
    }

   
    private void Pause()
    {
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
           
        }
        if (paused == true)
        {
            pauseMenu.SetActive(true);
            rb2D.simulated = false;
        }
        else if (paused == false)
        {
            pauseMenu.SetActive(false);
            rb2D.simulated = true;

        }

    }
    private void Jump()
    {
        
        if(doublejump == false)
        {
            if (Physics2D.Raycast(groundDet.transform.position, -groundDet.transform.up, 0.5f).collider != null)
            {
                if(Physics2D.Raycast(groundDet.transform.position, -groundDet.transform.up, 0.5f).collider.tag == "Ground" || Physics2D.Raycast(groundDet.transform.position, -groundDet.transform.up, 0.5f).collider.tag == "MovingPlatform")
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        rb2D.velocity = new Vector2(rb2D.velocity.x, jumpHeight);
                    }
                }
            }
        }else
        {
            if (Input.GetKeyDown(KeyCode.Space)&& amountOfJumps >0 )
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpHeight);
                amountOfJumps--;
            }
        }
       
        


    }

   
    private void Move()
    {
        moveSpeed = 10;
        float horizantal = Input.GetAxisRaw("Horizontal") * moveSpeed ;
        float horizontalInfo = Input.GetAxisRaw("Horizontal");
        if (horizontalInfo == 1)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(transform.rotation.x, transform.rotation.y, -10), 0.01f);
        }
        else if (horizontalInfo == -1)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(transform.rotation.x, transform.rotation.y, 10), 0.01f);
        }
        else if (horizontalInfo == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0), 0.01f);

        }
        rb2D.velocity = new Vector2(horizantal, rb2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Death"))
        {
            Death();
        }else if(collision.CompareTag("Win"))
        {
            CheckIfFinishedLevels();
            Win();
        }else if(collision.CompareTag("DoubleJump"))
        {
            doublejump = true;
            Destroy(collision.gameObject);
        }else if(collision.CompareTag("Button"))
        {
            if(collision.name != "ButtonTrap")
            {
                collision.GetComponent<Animator>().SetBool("Pressed", true);
                GameObject _goUpObject = GameObject.Find("GoUp");
                _goUpObject.GetComponent<Animator>().SetBool("GoUp", true);
            }else if(collision.name == "ButtonTrap")
            {
                collision.GetComponent<Animator>().SetBool("Pressed", true);
                GameObject _goUpObject = GameObject.Find("GoUpTrap");
                _goUpObject.GetComponent<Animator>().SetBool("GoUp", true);
            }
           
        }

        if (collision.CompareTag("MovingPlatform"))
        {
            transform.SetParent(collision.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("MovingPlatform"))
        {
            GameObject helpForThePlayer = GameObject.Find("HelpForThePlayer");

            transform.SetParent(helpForThePlayer.transform);

        }
    }

    void Win()
    {
        winMenu.SetActive(true);
    }

    void Death()
    {
        deathMenu.SetActive(true);
    }
    void CheckIfFinishedLevels()
    {
        ButtonManagerGamePlay gameManager = GameObject.FindObjectOfType<ButtonManagerGamePlay>();
        if (PlayerPrefs.GetString("Level1") != "true" && gameManager.sceneName == "Level1")
        {
            PlayerPrefs.SetString("Level1", "true");
        }
        else if (PlayerPrefs.GetString("Level2") != "true" && gameManager.sceneName == "Level2")
        {
            PlayerPrefs.SetString("Level2", "true");
        }
        else if (PlayerPrefs.GetString("Level3") != "true" && gameManager.sceneName == "Level3")
        {
            PlayerPrefs.SetString("Level3", "true");
        }
        else if (PlayerPrefs.GetString("Level4") != "true" && gameManager.sceneName == "Level4")
        {
            PlayerPrefs.SetString("Level4", "true");
        }
        else if (PlayerPrefs.GetString("Level5") != "true" && gameManager.sceneName == "Level5")
        {
            PlayerPrefs.SetString("Level5", "true");
        }
        else if (PlayerPrefs.GetString("Level6") != "true" && gameManager.sceneName == "Level6")
        {
            PlayerPrefs.SetString("Level6", "true");
        }
        else if (PlayerPrefs.GetString("Level7") != "true" && gameManager.sceneName == "Level7")
        {
            PlayerPrefs.SetString("Level7", "true");
        }
        else if (PlayerPrefs.GetString("Level8") != "true" && gameManager.sceneName == "Level8")
        {
            PlayerPrefs.SetString("Level8", "true");
        }
        else if (PlayerPrefs.GetString("Level9") != "true" && gameManager.sceneName == "Level9")
        {
            PlayerPrefs.SetString("Level9", "true");
        }
        else if (PlayerPrefs.GetString("Level10") != "true" && gameManager.sceneName == "Level10")
        {
            PlayerPrefs.SetString("Level10", "true");
        }
    }
}


