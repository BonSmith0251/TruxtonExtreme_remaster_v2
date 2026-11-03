namespace InGame.Kernel;

[Token(Token = "0x200006E")]
public class InGameObject : InGameObjectBase
{
	[Flags]
	[Token(Token = "0x200006F")]
	internal enum InGameObjectFlag : int
	{
		None = 0,
		OffCollision = 1,
		OffLockon = 2,
		Offthrough = 4,
		NoDamaged = 32,
		BomberRange = 64,
		NoBullet = 256,
		ForceFire = 512,
		Damaged = 16777216,
		Bombed = 33554432,
		EntryFrame = 67108864,
		EveryFrameClear = 117440512,
	}

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400038E")]
	private InGameObjectFlag _flagStateFuture; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400038F")]
	private InGameObjectFlag _flagStateNow; //Field offset: 0x6C

	[Address(RVA = "0x1D1D7C0", Offset = "0x1D1CBC0", Length = "0xE")]
	[Token(Token = "0x6000489")]
	public InGameObject() { }

	[Address(RVA = "0x1D1EC20", Offset = "0x1D1E020", Length = "0x15")]
	[Token(Token = "0x6000481")]
	public virtual void EntryInGame() { }

	[Address(RVA = "0x1D1EC40", Offset = "0x1D1E040", Length = "0xF")]
	[Token(Token = "0x6000486")]
	public bool IsFlagAll(InGameObjectFlag tflags) { }

	[Address(RVA = "0x1D1EC50", Offset = "0x1D1E050", Length = "0x7")]
	[Token(Token = "0x6000485")]
	public bool IsFlagFuture(InGameObjectFlag tflags) { }

	[Address(RVA = "0x1D1EC60", Offset = "0x1D1E060", Length = "0x7")]
	[Token(Token = "0x6000484")]
	public bool IsFlagNow(InGameObjectFlag tflags) { }

	[Address(RVA = "0x1D1EC70", Offset = "0x1D1E070", Length = "0x6")]
	[Token(Token = "0x6000483")]
	public void ResetFlag(InGameObjectFlag t) { }

	[Address(RVA = "0x1D1EC80", Offset = "0x1D1E080", Length = "0x1E")]
	[Token(Token = "0x6000488")]
	public override void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D1ECA0", Offset = "0x1D1E0A0", Length = "0x4")]
	[Token(Token = "0x6000482")]
	public void SetFlag(InGameObjectFlag t) { }

	[Address(RVA = "0x1D1ECB0", Offset = "0x1D1E0B0", Length = "0xE")]
	[Token(Token = "0x6000487")]
	public void UpdateFlag() { }

}

