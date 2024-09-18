using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float moveSpeed;
    private int maxHealth = 5;//最大生命值
    public int PublicMaxHealth { get { return maxHealth; } }
    private int currentHealth;
    private Animator animator;
    public int PublicCurrentHealth { get { return currentHealth; } }   //将currenthealth封装
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();     //获取自己身上的脚本
        //Application.targetFrameRate = 30;
        //currentHealth = maxHealth;
        currentHealth = 0;
        animator = GetComponentInChildren<Animator>();
        //animator.SetFloat("MoveValue",-1f);
        //animator.SetInteger("TestInt", 1);
    }
    void FixedUpdate()
    {
        //获取玩家水平输入值
        float horizontal = Input.GetAxis("Horizontal");
        //float yMove = Input.GetAxis("Vertical");
        //获取玩家垂直输入值
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical);
        rigidbody2d.MovePosition(rigidbody2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    // Update is called once per frame
    void Update()
    {

        //Debug.Log(horizontal);
        //Vector2 pos = transform.position;
   
        //pos.y = pos.y + 3 * vertical*Time.fixedDeltaTime;
        //pos.x = pos.x + 3 *horizontal*Time.fixedDeltaTime;
        //transform.position = pos;//
        
       // transform.position = pos;
      // rigidbody2d.MovePosition(pos);
        
    }
    public void ChangeHealth(int amount)
    {
        currentHealth= Mathf.Clamp(currentHealth +amount,0, maxHealth);//clamp函数限制范围
        Debug.Log(currentHealth+"/"+maxHealth);
    }
}
