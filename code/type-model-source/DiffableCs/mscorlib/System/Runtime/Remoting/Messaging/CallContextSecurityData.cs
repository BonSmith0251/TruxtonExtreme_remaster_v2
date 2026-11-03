namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003A3")]
internal class CallContextSecurityData : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E9B")]
	private IPrincipal _principal; //Field offset: 0x10

	[Token(Token = "0x1700032C")]
	internal bool HasInfo
	{
		[Address(RVA = "0x17A5210", Offset = "0x17A4610", Length = "0x9")]
		[Token(Token = "0x6001C5D")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001C5F")]
	public CallContextSecurityData() { }

	[Address(RVA = "0x1EFC000", Offset = "0x1EFB400", Length = "0x6B")]
	[Token(Token = "0x6001C5E")]
	public override object Clone() { }

	[Address(RVA = "0x17A5210", Offset = "0x17A4610", Length = "0x9")]
	[Token(Token = "0x6001C5D")]
	internal bool get_HasInfo() { }

}

