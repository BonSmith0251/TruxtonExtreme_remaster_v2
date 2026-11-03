namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
[Token(Token = "0x20003B0")]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000EC8")]
	private IActivator _activator; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000EC9")]
	private Object[] _activationAttributes; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000ECA")]
	private IList _contextProperties; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000ECB")]
	private Type _activationType; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000ECC")]
	private string _activationTypeName; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000ECD")]
	private bool _isContextOk; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000ECE")]
	private RemotingProxy _sourceProxy; //Field offset: 0x98

	[Token(Token = "0x1700033B")]
	public override Type ActivationType
	{
		[Address(RVA = "0x1F001A0", Offset = "0x1EFF5A0", Length = "0xBC")]
		[Token(Token = "0x6001CA4")]
		 get { } //Length: 188
	}

	[Token(Token = "0x1700033C")]
	public override string ActivationTypeName
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6001CA5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700033D")]
	public override IActivator Activator
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001CA6")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x6001CA7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700033E")]
	public override Object[] CallSiteActivationAttributes
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6001CA8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700033F")]
	public override IList ContextProperties
	{
		[Address(RVA = "0x1F00260", Offset = "0x1EFF660", Length = "0x69")]
		[Token(Token = "0x6001CAA")]
		 get { } //Length: 105
	}

	[Token(Token = "0x1700033A")]
	internal bool IsContextOk
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[Token(Token = "0x6001CA2")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
		[Token(Token = "0x6001CA3")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000340")]
	public virtual IDictionary Properties
	{
		[Address(RVA = "0x1F002D0", Offset = "0x1EFF6D0", Length = "0x37")]
		[Token(Token = "0x6001CAD")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000341")]
	internal RemotingProxy SourceProxy
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6001CAE")]
		internal get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x6001CAF")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x1F00120", Offset = "0x1EFF520", Length = "0x75")]
	[Token(Token = "0x6001C9F")]
	internal ConstructionCall(Type type) { }

	[Address(RVA = "0x1F00060", Offset = "0x1EFF460", Length = "0xB0")]
	[Token(Token = "0x6001CA0")]
	internal ConstructionCall(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F001A0", Offset = "0x1EFF5A0", Length = "0xBC")]
	[Token(Token = "0x6001CA4")]
	public override Type get_ActivationType() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6001CA5")]
	public override string get_ActivationTypeName() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001CA6")]
	public override IActivator get_Activator() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6001CA8")]
	public override Object[] get_CallSiteActivationAttributes() { }

	[Address(RVA = "0x1F00260", Offset = "0x1EFF660", Length = "0x69")]
	[Token(Token = "0x6001CAA")]
	public override IList get_ContextProperties() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[Token(Token = "0x6001CA2")]
	internal bool get_IsContextOk() { }

	[Address(RVA = "0x1F002D0", Offset = "0x1EFF6D0", Length = "0x37")]
	[Token(Token = "0x6001CAD")]
	public virtual IDictionary get_Properties() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6001CAE")]
	internal RemotingProxy get_SourceProxy() { }

	[Address(RVA = "0x1EFF9E0", Offset = "0x1EFEDE0", Length = "0x137")]
	[Token(Token = "0x6001CAC")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EFFB20", Offset = "0x1EFEF20", Length = "0x106")]
	[Token(Token = "0x6001CA1")]
	internal virtual void InitDictionary() { }

	[Address(RVA = "0x1EFFC30", Offset = "0x1EFF030", Length = "0x428")]
	[Token(Token = "0x6001CAB")]
	internal virtual void InitMethodProperty(string key, object value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x6001CA7")]
	public override void set_Activator(IActivator value) { }

	[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
	[Token(Token = "0x6001CA3")]
	internal void set_IsContextOk(bool value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x6001CAF")]
	internal void set_SourceProxy(RemotingProxy value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x6001CA9")]
	internal void SetActivationAttributes(Object[] attributes) { }

}

