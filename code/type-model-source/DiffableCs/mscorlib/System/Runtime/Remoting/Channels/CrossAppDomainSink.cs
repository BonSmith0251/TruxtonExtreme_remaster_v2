namespace System.Runtime.Remoting.Channels;

[MonoTODO("Handle domain unloading?")]
[Token(Token = "0x2000385")]
internal class CrossAppDomainSink : IMessageSink
{
	[Token(Token = "0x2000386")]
	private struct ProcessMessageRes
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E74")]
		public Byte[] arrResponse; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000E75")]
		public CADMethodReturnMessage cadMrm; //Field offset: 0x8

	}

	[Token(Token = "0x4000E71")]
	private static Hashtable s_sinks; //Field offset: 0x0
	[Token(Token = "0x4000E72")]
	private static MethodInfo processMessageMethod; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E73")]
	private int _domainID; //Field offset: 0x10

	[Token(Token = "0x17000304")]
	internal int TargetDomainId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001BF5")]
		internal get { } //Length: 85
	}

	[Address(RVA = "0x1F01900", Offset = "0x1F00D00", Length = "0xFF")]
	[Token(Token = "0x6001BFA")]
	private static CrossAppDomainSink() { }

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6001BF3")]
	internal CrossAppDomainSink(int domainID) { }

	[Address(RVA = "0x1F01840", Offset = "0x1F00C40", Length = "0xBD")]
	[CompilerGenerated]
	[Token(Token = "0x6001BFB")]
	private void <AsyncProcessMessage>b__10_0(object data) { }

	[Address(RVA = "0x1F00F00", Offset = "0x1F00300", Length = "0xD3")]
	[Token(Token = "0x6001BF8")]
	public override IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6001BF5")]
	internal int get_TargetDomainId() { }

	[Address(RVA = "0x1F00FE0", Offset = "0x1F003E0", Length = "0x2C5")]
	[Token(Token = "0x6001BF4")]
	internal static CrossAppDomainSink GetSink(int domainID) { }

	[Address(RVA = "0x1F012B0", Offset = "0x1F006B0", Length = "0xFF")]
	[Token(Token = "0x6001BF6")]
	private static ProcessMessageRes ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	[Address(RVA = "0x1F013B0", Offset = "0x1F007B0", Length = "0xB4")]
	[Token(Token = "0x6001BF9")]
	public void SendAsyncMessage(object data) { }

	[Address(RVA = "0x1F01470", Offset = "0x1F00870", Length = "0x3C8")]
	[Token(Token = "0x6001BF7")]
	public override IMessage SyncProcessMessage(IMessage msgRequest) { }

}

