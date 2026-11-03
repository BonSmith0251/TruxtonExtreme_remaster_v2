namespace System.Runtime.Remoting.Contexts;

[Token(Token = "0x2000373")]
internal class DynamicPropertyCollection
{
	[Token(Token = "0x2000374")]
	private class DynamicPropertyReg
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E63")]
		public IDynamicProperty Property; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E64")]
		public IDynamicMessageSink Sink; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001BC3")]
		public DynamicPropertyReg() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E62")]
	private ArrayList _properties; //Field offset: 0x10

	[Token(Token = "0x170002FB")]
	public bool HasProperties
	{
		[Address(RVA = "0x1EE1D30", Offset = "0x1EE1130", Length = "0x2F")]
		[Token(Token = "0x6001BBD")]
		 get { } //Length: 47
	}

	[Address(RVA = "0x1EE1CC0", Offset = "0x1EE10C0", Length = "0x66")]
	[Token(Token = "0x6001BC2")]
	public DynamicPropertyCollection() { }

	[Address(RVA = "0x1EE13B0", Offset = "0x1EE07B0", Length = "0x12B")]
	[Token(Token = "0x6001BC1")]
	private int FindProperty(string name) { }

	[Address(RVA = "0x1EE1D30", Offset = "0x1EE1130", Length = "0x2F")]
	[Token(Token = "0x6001BBD")]
	public bool get_HasProperties() { }

	[Address(RVA = "0x1EE14E0", Offset = "0x1EE08E0", Length = "0x456")]
	[Token(Token = "0x6001BC0")]
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	[Address(RVA = "0x1EE1940", Offset = "0x1EE0D40", Length = "0x22D")]
	[Token(Token = "0x6001BBE")]
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	[Address(RVA = "0x1EE1B70", Offset = "0x1EE0F70", Length = "0x140")]
	[Token(Token = "0x6001BBF")]
	public bool UnregisterDynamicProperty(string name) { }

}

