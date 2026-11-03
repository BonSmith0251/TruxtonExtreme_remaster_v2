namespace Unity.Profiling;

[IsReadOnly]
[Token(Token = "0x2000025")]
[UsedByNativeCode]
public struct ProfilerCategory
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000035")]
	private readonly ushort m_CategoryId; //Field offset: 0x0

	[Token(Token = "0x17000008")]
	public string Name
	{
		[Address(RVA = "0x2FE3D70", Offset = "0x2FE3170", Length = "0x12C")]
		[Token(Token = "0x600006F")]
		 get { } //Length: 300
	}

	[Token(Token = "0x17000009")]
	public static ProfilerCategory Scripts
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000071")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x600006E")]
	internal ProfilerCategory(ushort category) { }

	[Address(RVA = "0x2FE3D70", Offset = "0x2FE3170", Length = "0x12C")]
	[Token(Token = "0x600006F")]
	public string get_Name() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000071")]
	public static ProfilerCategory get_Scripts() { }

	[Address(RVA = "0x2FE3EA0", Offset = "0x2FE32A0", Length = "0x6")]
	[Token(Token = "0x6000072")]
	public static ushort op_Implicit(ProfilerCategory category) { }

	[Address(RVA = "0x2FE3D60", Offset = "0x2FE3160", Length = "0x9")]
	[Token(Token = "0x6000070")]
	public virtual string ToString() { }

}

