namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000455")]
public sealed class DllImportAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400120F")]
	internal string _val; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001210")]
	public string EntryPoint; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001211")]
	public CharSet CharSet; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001212")]
	public bool SetLastError; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4001213")]
	public bool ExactSpelling; //Field offset: 0x25
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x4001214")]
	public bool PreserveSig; //Field offset: 0x26
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001215")]
	public CallingConvention CallingConvention; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001216")]
	public bool BestFitMapping; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4001217")]
	public bool ThrowOnUnmappableChar; //Field offset: 0x2D

	[Token(Token = "0x170003EF")]
	public string Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6002036")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F34010", Offset = "0x1F33410", Length = "0x8E")]
	[Token(Token = "0x6002034")]
	internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6002035")]
	public DllImportAttribute(string dllName) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6002036")]
	public string get_Value() { }

	[Address(RVA = "0x1F33D60", Offset = "0x1F33160", Length = "0x264")]
	[Token(Token = "0x6002032")]
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	[Address(RVA = "0x1F33FE0", Offset = "0x1F333E0", Length = "0x2E")]
	[Token(Token = "0x6002033")]
	internal static bool IsDefined(RuntimeMethodInfo method) { }

}

