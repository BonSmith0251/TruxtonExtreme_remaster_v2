namespace Unity.Profiling;

[Token(Token = "0x2000031")]
public struct DebugScreenCapture
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006D")]
	private NativeArray<Byte> <RawImageDataReference>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006E")]
	private TextureFormat <ImageFormat>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400006F")]
	private int <Width>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000070")]
	private int <Height>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000012")]
	public int Height
	{
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000094")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public TextureFormat ImageFormat
	{
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000092")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public NativeArray<Byte> RawImageDataReference
	{
		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000091")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000011")]
	public int Width
	{
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000093")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000094")]
	public void set_Height(int value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000092")]
	public void set_ImageFormat(TextureFormat value) { }

	[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000091")]
	public void set_RawImageDataReference(NativeArray<Byte> value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000093")]
	public void set_Width(int value) { }

}

