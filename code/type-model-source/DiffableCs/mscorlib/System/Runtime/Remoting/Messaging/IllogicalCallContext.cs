namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003A0")]
internal class IllogicalCallContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E92")]
	private Hashtable m_Datastore; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E93")]
	private object m_HostContext; //Field offset: 0x18

	[Token(Token = "0x17000324")]
	private Hashtable Datastore
	{
		[Address(RVA = "0x1F05010", Offset = "0x1F04410", Length = "0x69")]
		[Token(Token = "0x6001C46")]
		private get { } //Length: 105
	}

	[Token(Token = "0x17000326")]
	internal bool HasUserData
	{
		[Address(RVA = "0x1F05080", Offset = "0x1F04480", Length = "0x33")]
		[Token(Token = "0x6001C49")]
		internal get { } //Length: 51
	}

	[Token(Token = "0x17000325")]
	internal object HostContext
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001C47")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001C48")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001C4C")]
	public IllogicalCallContext() { }

	[Address(RVA = "0x1F04C40", Offset = "0x1F04040", Length = "0x325")]
	[Token(Token = "0x6001C4B")]
	public IllogicalCallContext CreateCopy() { }

	[Address(RVA = "0x1F04F70", Offset = "0x1F04370", Length = "0x96")]
	[Token(Token = "0x6001C4A")]
	public void FreeNamedDataSlot(string name) { }

	[Address(RVA = "0x1F05010", Offset = "0x1F04410", Length = "0x69")]
	[Token(Token = "0x6001C46")]
	private Hashtable get_Datastore() { }

	[Address(RVA = "0x1F05080", Offset = "0x1F04480", Length = "0x33")]
	[Token(Token = "0x6001C49")]
	internal bool get_HasUserData() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001C47")]
	internal object get_HostContext() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001C48")]
	internal void set_HostContext(object value) { }

}

