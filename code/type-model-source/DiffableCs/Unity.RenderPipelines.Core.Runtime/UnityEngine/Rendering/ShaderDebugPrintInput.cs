namespace UnityEngine.Rendering;

[Token(Token = "0x20000DE")]
public struct ShaderDebugPrintInput
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D0")]
	private Vector2 <pos>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002D1")]
	private bool <leftDown>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x40002D2")]
	private bool <rightDown>k__BackingField; //Field offset: 0x9
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x40002D3")]
	private bool <middleDown>k__BackingField; //Field offset: 0xA

	[Token(Token = "0x170000CB")]
	public bool leftDown
	{
		[Address(RVA = "0xAEF450", Offset = "0xAEE850", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60007DA")]
		 get { } //Length: 5
		[Address(RVA = "0x1BB2EC0", Offset = "0x1BB22C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007DB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000CD")]
	public bool middleDown
	{
		[Address(RVA = "0x1FA80D0", Offset = "0x1FA74D0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60007DE")]
		 get { } //Length: 5
		[Address(RVA = "0x2C1D6C0", Offset = "0x2C1CAC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007DF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000CA")]
	public Vector2 pos
	{
		[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60007D8")]
		 get { } //Length: 18
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007D9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000CC")]
	public bool rightDown
	{
		[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60007DC")]
		 get { } //Length: 5
		[Address(RVA = "0x1BB2F50", Offset = "0x1BB2350", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007DD")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAEF450", Offset = "0xAEE850", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60007DA")]
	public bool get_leftDown() { }

	[Address(RVA = "0x1FA80D0", Offset = "0x1FA74D0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60007DE")]
	public bool get_middleDown() { }

	[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60007D8")]
	public Vector2 get_pos() { }

	[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60007DC")]
	public bool get_rightDown() { }

	[Address(RVA = "0x1BB2EC0", Offset = "0x1BB22C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007DB")]
	public void set_leftDown(bool value) { }

	[Address(RVA = "0x2C1D6C0", Offset = "0x2C1CAC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007DF")]
	public void set_middleDown(bool value) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007D9")]
	public void set_pos(Vector2 value) { }

	[Address(RVA = "0x1BB2F50", Offset = "0x1BB2350", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007DD")]
	public void set_rightDown(bool value) { }

	[Address(RVA = "0x2C1D450", Offset = "0x2C1C850", Length = "0x265")]
	[Token(Token = "0x60007E0")]
	public string String() { }

}

