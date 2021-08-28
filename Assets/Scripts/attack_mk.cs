
public class attack_mk : MonoBehaviour
{
    public Transform attackpoint;
    public float attackrange = 2;
    public LayerMask enemylayers;
    public Text RedHP;
    public int v;



public class attack_mk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
>>>>>>> 1c3ffff99463cf5af1b51b7c740d7412e95f0616

    // Update is called once per frame
    void Update()
    {

        Vector2 position = transform.position;
        attackpoint.position = position;
        Debug.Log("before if statement.");
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("you are attacking.");
            Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemylayers);
            Debug.Log(hitenemies);
            foreach (Collider2D enemy in hitenemies)
            {
                Debug.Log("We hit" + enemy.name);
                v = int.Parse(RedHP.text);
                v -= 10;
                if (v > 0) { RedHP.text = v.ToString(); }
                else RedHP.text = "0";


            }
            Debug.Log("after the foreach");

        }
        Debug.Log("After if");
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);

        if (Input.GetKeyDown(KeyCode.X))
        {
            
        }

    }
}
