namespace TXEKernel.InGame;

[CreateAssetMenu(fileName = "GameAddPoints", menuName = "InGame/GameAddPoints", order = 0)]
[Token(Token = "0x2000137")]
public class GameAddPoints : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008DB")]
	public PlayMode targetPlayMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40008DC")]
	public PlayActor targetActor; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008DD")]
	public Vector2[] _ClampBase; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Range(-1000, 1000)]
	[Token(Token = "0x40008DE")]
	public float StartPoint; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Range(-1000, 1000)]
	[Token(Token = "0x40008DF")]
	public float ASecondAdd; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Range(-1000, 1000)]
	[Token(Token = "0x40008E0")]
	public float APowerupAdd; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Range(-1000, 1000)]
	[Token(Token = "0x40008E1")]
	public float ABomberedAdd; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(-1000, 1000)]
	[Token(Token = "0x40008E2")]
	public float ABomberStockAdd; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Range(-1000, 1000)]
	[Token(Token = "0x40008E3")]
	public float AEnemyDestroyAdd; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Range(-1000, 1000)]
	[Token(Token = "0x40008E4")]
	public float ABossDestroyAdd; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Range(-1000, 1000)]
	[Token(Token = "0x40008E5")]
	public float APlayerDeadAdd; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Range(0, 1000)]
	[Token(Token = "0x40008E6")]
	public float RoundPerUpMin; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Range(0, 1000)]
	[Token(Token = "0x40008E7")]
	public float RoundPerUpMax; //Field offset: 0x4C

	[Address(RVA = "0x2720B70", Offset = "0x271FF70", Length = "0x1C")]
	[Token(Token = "0x600087C")]
	public GameAddPoints() { }

	[Address(RVA = "0x2720B20", Offset = "0x271FF20", Length = "0x4E")]
	[Token(Token = "0x600087B")]
	public Vector2 GetClamp(int nstage) { }

}

