namespace Mono;

[Token(Token = "0x2000045")]
internal struct SafeStringMarshal : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000137")]
	private readonly string str; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000138")]
	private IntPtr marshaled_string; //Field offset: 0x8

	[Token(Token = "0x1700000F")]
	public IntPtr Value
	{
		[Address(RVA = "0x1E64C50", Offset = "0x1E64050", Length = "0x3C")]
		[Token(Token = "0x6000072")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x1E64C30", Offset = "0x1E64030", Length = "0x1F")]
	[Token(Token = "0x6000071")]
	public SafeStringMarshal(string str) { }

	[Address(RVA = "0x1E64BC0", Offset = "0x1E63FC0", Length = "0x27")]
	[Token(Token = "0x6000073")]
	public override void Dispose() { }

	[Address(RVA = "0x1E64C50", Offset = "0x1E64050", Length = "0x3C")]
	[Token(Token = "0x6000072")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x1E64BF0", Offset = "0x1E63FF0", Length = "0x5")]
	[Token(Token = "0x6000070")]
	public static void GFree(IntPtr ptr) { }

	[Address(RVA = "0x1E64C10", Offset = "0x1E64010", Length = "0x18")]
	[Token(Token = "0x600006F")]
	public static IntPtr StringToUtf8(string str) { }

	[Address(RVA = "0x1E64C00", Offset = "0x1E64000", Length = "0x5")]
	[Token(Token = "0x600006E")]
	private static IntPtr StringToUtf8_icall(ref string str) { }

}

