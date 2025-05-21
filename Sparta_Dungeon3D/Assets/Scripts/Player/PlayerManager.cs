using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //싱글톤으로 전역 접근. 안전성을 위해 getter 사용함
    private static PlayerManager instance;
    public static PlayerManager Instance
    {
        get
        { 
            //유니티 Hierarchy에 PlayerManager가 없을 경우 생성
            if (instance == null)
            {
                instance = new GameObject("PlayerManager").AddComponent<PlayerManager>();
            }

            return instance;
        }
    }

    private Player player;
    public Player Player { get { return player; } set { player = value; } }

    private void Awake()
    {
        //인스턴스가 없으면 할당
        if(instance == null)
        {
            instance = this;
            //씬 이동시 유지
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //다른 싱글톤이 존재하면, 자기 자신은 중복이니 삭제
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}
