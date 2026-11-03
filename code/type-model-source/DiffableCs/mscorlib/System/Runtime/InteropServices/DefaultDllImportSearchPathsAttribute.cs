namespace System.Runtime.InteropServices;

[AttributeUsage(65, AllowMultiple = False)]
[ComVisible(False)]
[Token(Token = "0x2000454")]
public sealed class DefaultDllImportSearchPathsAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400120E")]
	internal DllImportSearchPath _paths; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6002031")]
	public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths) { }

}

