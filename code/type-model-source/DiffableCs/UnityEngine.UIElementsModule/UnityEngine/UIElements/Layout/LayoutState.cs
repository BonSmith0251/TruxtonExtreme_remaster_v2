namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000628")]
internal struct LayoutState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016AE")]
	public IntPtr measureFunctionCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40016AF")]
	public IntPtr baselineFunctionCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016B0")]
	public IntPtr unusedExceptionPointer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016B1")]
	public uint depth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40016B2")]
	public uint currentGenerationCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016B3")]
	public bool error; //Field offset: 0x20

	[Token(Token = "0x17000AF4")]
	public static LayoutState Default
	{
		[Address(RVA = "0x3323C20", Offset = "0x3323020", Length = "0x72")]
		[Token(Token = "0x6002B8C")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x3323C20", Offset = "0x3323020", Length = "0x72")]
	[Token(Token = "0x6002B8C")]
	public static LayoutState get_Default() { }

}

