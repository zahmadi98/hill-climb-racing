using UnityEngine;

public class DriverDeathFromHead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Ground")) {
            GameManager.instance.GameOver();
        }
    }
}
