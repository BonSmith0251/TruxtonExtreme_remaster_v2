namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003A1")]
public sealed class LogicalCallContext : ISerializable, ICloneable
{
	[Token(Token = "0x20003A2")]
	public struct Reader
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E9A")]
		private LogicalCallContext m_ctx; //Field offset: 0x0

		[Token(Token = "0x1700032B")]
		public bool HasInfo
		{
			[Address(RVA = "0x1F11FB0", Offset = "0x1F113B0", Length = "0x77")]
			[Token(Token = "0x6001C5A")]
			 get { } //Length: 119
		}

		[Token(Token = "0x1700032A")]
		public bool IsNull
		{
			[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
			[Token(Token = "0x6001C59")]
			 get { } //Length: 8
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6001C58")]
		public Reader(LogicalCallContext ctx) { }

		[Address(RVA = "0x1F11E90", Offset = "0x1F11290", Length = "0x64")]
		[Token(Token = "0x6001C5B")]
		public LogicalCallContext Clone() { }

		[Address(RVA = "0x1F11FB0", Offset = "0x1F113B0", Length = "0x77")]
		[Token(Token = "0x6001C5A")]
		public bool get_HasInfo() { }

		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x6001C59")]
		public bool get_IsNull() { }

		[Address(RVA = "0x1F11F00", Offset = "0x1F11300", Length = "0xA4")]
		[Token(Token = "0x6001C5C")]
		public object GetData(string name) { }

	}

	[Token(Token = "0x4000E94")]
	private static Type s_callContextType; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E95")]
	private Hashtable m_Datastore; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E96")]
	private CallContextRemotingData m_RemotingData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E97")]
	private CallContextSecurityData m_SecurityData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E98")]
	private object m_HostContext; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E99")]
	private bool m_IsCorrelationMgr; //Field offset: 0x30

	[Token(Token = "0x17000329")]
	private Hashtable Datastore
	{
		[Address(RVA = "0x1F06850", Offset = "0x1F05C50", Length = "0x69")]
		[Token(Token = "0x6001C54")]
		private get { } //Length: 105
	}

	[Token(Token = "0x17000327")]
	public bool HasInfo
	{
		[Address(RVA = "0x1F068C0", Offset = "0x1F05CC0", Length = "0x60")]
		[Token(Token = "0x6001C52")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000328")]
	private bool HasUserData
	{
		[Address(RVA = "0x1F05080", Offset = "0x1F04480", Length = "0x33")]
		[Token(Token = "0x6001C53")]
		private get { } //Length: 51
	}

	[Address(RVA = "0x1F060C0", Offset = "0x1F054C0", Length = "0x80")]
	[Token(Token = "0x6001C57")]
	private static LogicalCallContext() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001C4D")]
	internal LogicalCallContext() { }

	[Address(RVA = "0x1F06140", Offset = "0x1F05540", Length = "0x707")]
	[Token(Token = "0x6001C4E")]
	internal LogicalCallContext(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F050C0", Offset = "0x1F044C0", Length = "0x79E")]
	[Token(Token = "0x6001C50")]
	public override object Clone() { }

	[Address(RVA = "0x1F06850", Offset = "0x1F05C50", Length = "0x69")]
	[Token(Token = "0x6001C54")]
	private Hashtable get_Datastore() { }

	[Address(RVA = "0x1F068C0", Offset = "0x1F05CC0", Length = "0x60")]
	[Token(Token = "0x6001C52")]
	public bool get_HasInfo() { }

	[Address(RVA = "0x1F05080", Offset = "0x1F04480", Length = "0x33")]
	[Token(Token = "0x6001C53")]
	private bool get_HasUserData() { }

	[Address(RVA = "0x1F05860", Offset = "0x1F04C60", Length = "0x96")]
	[Token(Token = "0x6001C55")]
	public object GetData(string name) { }

	[Address(RVA = "0x1F05900", Offset = "0x1F04D00", Length = "0x3B0")]
	[Token(Token = "0x6001C4F")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F05CC0", Offset = "0x1F050C0", Length = "0x302")]
	[Token(Token = "0x6001C51")]
	internal void Merge(LogicalCallContext lc) { }

	[Address(RVA = "0x1F05FD0", Offset = "0x1F053D0", Length = "0xE0")]
	[Token(Token = "0x6001C56")]
	public void SetData(string name, object data) { }

}

