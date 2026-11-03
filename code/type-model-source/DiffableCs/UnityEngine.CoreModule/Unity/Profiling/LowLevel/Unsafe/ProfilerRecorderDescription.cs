namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
[Token(Token = "0x2000034")]
[UsedByNativeCode]
public struct ProfilerRecorderDescription
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008A")]
	private readonly ProfilerCategory category; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400008B")]
	private readonly MarkerFlags flags; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400008C")]
	private readonly ProfilerMarkerDataType dataType; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x400008D")]
	private readonly ProfilerMarkerDataUnit unitType; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400008E")]
	private readonly int reserved0; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400008F")]
	private readonly int nameUtf8Len; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000090")]
	private readonly Byte* nameUtf8; //Field offset: 0x10

	[Token(Token = "0x17000013")]
	public MarkerFlags Flags
	{
		[Address(RVA = "0x6466D0", Offset = "0x645AD0", Length = "0x5")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x6466D0", Offset = "0x645AD0", Length = "0x5")]
	[Token(Token = "0x6000095")]
	public MarkerFlags get_Flags() { }

}

