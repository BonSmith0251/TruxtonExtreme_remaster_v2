namespace TXEKernel;

[CreateAssetMenu(menuName = "InGame/ExtendScores")]
[Token(Token = "0x2000044")]
public class ExtendScores : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000175")]
	private long _startExtend; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000176")]
	private long _stepExtend; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000177")]
	private long _endExtend; //Field offset: 0x28

	[Address(RVA = "0x26D2D70", Offset = "0x26D2170", Length = "0x1F")]
	[Token(Token = "0x60001FA")]
	public ExtendScores() { }

	[Address(RVA = "0x26D2D10", Offset = "0x26D2110", Length = "0x4E")]
	[Token(Token = "0x60001F9")]
	public int GetExtentCount(long nowScore, long addScore) { }

	[Address(RVA = "0x26D2D60", Offset = "0x26D2160", Length = "0xD")]
	[Token(Token = "0x60001F8")]
	public void SetParams(long st, long ns, long ed = 100000000) { }

}

