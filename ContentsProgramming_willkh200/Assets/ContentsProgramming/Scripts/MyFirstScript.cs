using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start는 게임 시작할 때 한 번 실행됩니다
    void Start()
    {
        // 우리의 첫 프로그램!
        Debug.Log("안녕하세요! 제 첫 프로그램이에요!");
        Debug.Log("Unity에서 첫 스크립트를 작성하고 있어요.");

        // 숫자도 출력해봅시다
        Debug.Log("제가 좋아하는 숫자: 7");
        Debug.Log("제가 좋아하는 숫자: " + 42);

        // 계산도 가능합니다
        Debug.Log(10 + 20);
    }
}