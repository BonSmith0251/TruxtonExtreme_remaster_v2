namespace InGame.Kernel.Player;

[CreateAssetMenu(menuName = "KANAI/PlayerDefinedFighter")]
[Token(Token = "0x2000117")]
public class PlayerDefinedFighter : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Range(0.1, 2000)]
	[SerializeField]
	[Token(Token = "0x40007F5")]
	[Tooltip("傾きが完了するまでの時間(ミリ秒)")]
	public float YawSpeedTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Range(0.001, 2)]
	[SerializeField]
	[Token(Token = "0x40007F6")]
	[Tooltip("速度に変化に対する傾き速度の割合")]
	public List<Single> YawSpeedFactor; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Range(0, 90)]
	[SerializeField]
	[Token(Token = "0x40007F7")]
	[Tooltip("最大傾斜角")]
	public float YawRotateMax; //Field offset: 0x28

	[Address(RVA = "0x1D4EA10", Offset = "0x1D4DE10", Length = "0x69")]
	[Token(Token = "0x60008E4")]
	private float _getYawSpeedFactor(int index) { }

	[Address(RVA = "0x1D4E980", Offset = "0x1D4DD80", Length = "0x8A")]
	[Token(Token = "0x60008E5")]
	public PlayerDefinedFighter() { }

	[Address(RVA = "0x1D4E900", Offset = "0x1D4DD00", Length = "0x7C")]
	[Token(Token = "0x60008E3")]
	public float GetYawSpeedTime(int index) { }

}

