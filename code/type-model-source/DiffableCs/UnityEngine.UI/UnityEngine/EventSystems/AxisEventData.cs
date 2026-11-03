namespace UnityEngine.EventSystems;

[Token(Token = "0x200009A")]
public class AxisEventData : BaseEventData
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002CE")]
	private Vector2 <moveVector>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002CF")]
	private MoveDirection <moveDir>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700019D")]
	public MoveDirection moveDir
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600062E")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600062F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700019C")]
	public Vector2 moveVector
	{
		[Address(RVA = "0x3461330", Offset = "0x3460730", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600062C")]
		 get { } //Length: 19
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600062D")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x34612B0", Offset = "0x34606B0", Length = "0x76")]
	[Token(Token = "0x6000630")]
	public AxisEventData(EventSystem eventSystem) { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600062E")]
	public MoveDirection get_moveDir() { }

	[Address(RVA = "0x3461330", Offset = "0x3460730", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600062C")]
	public Vector2 get_moveVector() { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600062F")]
	public void set_moveDir(MoveDirection value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600062D")]
	public void set_moveVector(Vector2 value) { }

}

