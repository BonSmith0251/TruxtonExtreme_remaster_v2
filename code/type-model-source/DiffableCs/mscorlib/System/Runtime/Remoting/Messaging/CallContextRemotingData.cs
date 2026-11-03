namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003A4")]
internal class CallContextRemotingData : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E9C")]
	private string _logicalCallID; //Field offset: 0x10

	[Token(Token = "0x1700032E")]
	internal bool HasInfo
	{
		[Address(RVA = "0x17A5210", Offset = "0x17A4610", Length = "0x9")]
		[Token(Token = "0x6001C62")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x1700032D")]
	internal string LogicalCallID
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001C60")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6001C61")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001C64")]
	public CallContextRemotingData() { }

	[Address(RVA = "0x1EFBF90", Offset = "0x1EFB390", Length = "0x6B")]
	[Token(Token = "0x6001C63")]
	public override object Clone() { }

	[Address(RVA = "0x17A5210", Offset = "0x17A4610", Length = "0x9")]
	[Token(Token = "0x6001C62")]
	internal bool get_HasInfo() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001C60")]
	internal string get_LogicalCallID() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6001C61")]
	internal void set_LogicalCallID(string value) { }

}

