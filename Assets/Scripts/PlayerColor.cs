using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColor : MonoBehaviour
{
    public string currentColor;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorMagenta;

    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        SetRandomColor();
    }
    private void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = ("Cyan");
                spriteRenderer.color = colorCyan;
                break;
            case 1:
                currentColor = ("Yellow");
                spriteRenderer.color = colorYellow;
                break;
            case 2:
                currentColor = ("Pink");
                spriteRenderer.color = colorPink;
                break;
            case 3:
                currentColor = ("Magenta");
                spriteRenderer.color = colorMagenta;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag != currentColor)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Game over ");
        }
    }
}
