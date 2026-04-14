using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [field:SerializeField] public PlayerController Player { get; private set; }
}
