namespace TXEKernel.InGame;

[CreateAssetMenu(fileName = "GameScalability", menuName = "InGame/GameScalability", order = 1)]
[Token(Token = "0x2000138")]
public class GameScalability : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40008E8")]
	[Tooltip("小さいほど遅い")]
	private Vector2 _bulletSpeedScale; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40008E9")]
	[Tooltip("大きいほど遅い")]
	private Vector2 _eventRepeatScale; //Field offset: 0x20

	[Address(RVA = "0x2720C90", Offset = "0x2720090", Length = "0x94")]
	[Token(Token = "0x600087F")]
	public GameScalability() { }

	[Address(RVA = "0x2720B90", Offset = "0x271FF90", Length = "0x72")]
	[Token(Token = "0x600087D")]
	public float GetBulletSpeedScale(float diPoint) { }

	[Address(RVA = "0x2720C10", Offset = "0x2720010", Length = "0x72")]
	[Token(Token = "0x600087E")]
	public float GetEventRepeatScale(float diPoint) { }

}

