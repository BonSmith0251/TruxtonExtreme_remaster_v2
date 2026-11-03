namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003A2")]
internal struct XUserLocalId
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A5F")]
	private ulong <value>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000309")]
	public ulong value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600124E")]
		 get { } //Length: 4
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600124F")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600124E")]
	public ulong get_value() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600124F")]
	public void set_value(ulong value) { }

}

