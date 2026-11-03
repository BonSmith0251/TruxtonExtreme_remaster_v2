namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003AC")]
internal class CADMethodCallMessage : CADMessageBase
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EC1")]
	private string _uri; //Field offset: 0x38

	[Token(Token = "0x17000338")]
	internal int PropertiesCount
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6001C91")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000337")]
	internal string Uri
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001C8C")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1EFA950", Offset = "0x1EF9D50", Length = "0x2CC")]
	[Token(Token = "0x6001C8E")]
	internal CADMethodCallMessage(IMethodCallMessage callMsg) { }

	[Address(RVA = "0x1EFA6F0", Offset = "0x1EF9AF0", Length = "0x82")]
	[Token(Token = "0x6001C8D")]
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6001C91")]
	internal int get_PropertiesCount() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001C8C")]
	internal string get_Uri() { }

	[Address(RVA = "0x1EFA780", Offset = "0x1EF9B80", Length = "0xF")]
	[Token(Token = "0x6001C90")]
	internal Object[] GetArgs(ArrayList args) { }

	[Address(RVA = "0x1EFA790", Offset = "0x1EF9B90", Length = "0x1B2")]
	[Token(Token = "0x6001C8F")]
	internal ArrayList GetArguments() { }

}

