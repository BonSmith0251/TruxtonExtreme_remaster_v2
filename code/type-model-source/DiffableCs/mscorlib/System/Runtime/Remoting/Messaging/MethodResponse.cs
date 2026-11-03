namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
[Token(Token = "0x20003C2")]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EE5")]
	private string _methodName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EE6")]
	private string _uri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EE7")]
	private string _typeName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EE8")]
	private MethodBase _methodBase; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EE9")]
	private object _returnValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EEA")]
	private Exception _exception; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000EEB")]
	private Type[] _methodSignature; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EEC")]
	private ArgInfo _inArgInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000EED")]
	private Object[] _args; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000EEE")]
	private Object[] _outArgs; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000EEF")]
	private IMethodCallMessage _callMsg; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000EF0")]
	private LogicalCallContext _callContext; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000EF1")]
	private Identity _targetIdentity; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000EF2")]
	protected IDictionary ExternalProperties; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000EF3")]
	protected IDictionary InternalProperties; //Field offset: 0x80

	[Token(Token = "0x17000374")]
	public override int ArgCount
	{
		[Address(RVA = "0x1F0AEC0", Offset = "0x1F0A2C0", Length = "0x12")]
		[Token(Token = "0x6001D1E")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000375")]
	public override Object[] Args
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001D1F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000376")]
	public override Exception Exception
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001D20")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000377")]
	public override LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x1F0AEE0", Offset = "0x1F0A2E0", Length = "0x69")]
		[Token(Token = "0x6001D21")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000378")]
	public override MethodBase MethodBase
	{
		[Address(RVA = "0x1F0AF50", Offset = "0x1F0A350", Length = "0x15C")]
		[Token(Token = "0x6001D22")]
		 get { } //Length: 348
	}

	[Token(Token = "0x17000379")]
	public override string MethodName
	{
		[Address(RVA = "0x1F0B0B0", Offset = "0x1F0A4B0", Length = "0x62")]
		[Token(Token = "0x6001D23")]
		 get { } //Length: 98
	}

	[Token(Token = "0x1700037A")]
	public override object MethodSignature
	{
		[Address(RVA = "0x1F0B120", Offset = "0x1F0A520", Length = "0xD2")]
		[Token(Token = "0x6001D24")]
		 get { } //Length: 210
	}

	[Token(Token = "0x1700037B")]
	public override Object[] OutArgs
	{
		[Address(RVA = "0x1F0B200", Offset = "0x1F0A600", Length = "0x20A")]
		[Token(Token = "0x6001D25")]
		 get { } //Length: 522
	}

	[Token(Token = "0x1700037C")]
	public override IDictionary Properties
	{
		[Address(RVA = "0x1F00530", Offset = "0x1EFF930", Length = "0xBB")]
		[Token(Token = "0x6001D26")]
		 get { } //Length: 187
	}

	[Token(Token = "0x1700037D")]
	public override object ReturnValue
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001D27")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000381")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6001D2F")]
		private get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x6001D30")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000380")]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		[Address(RVA = "0x1F0A850", Offset = "0x1F09C50", Length = "0x62")]
		[Token(Token = "0x6001D2B")]
		private get { } //Length: 98
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001D2C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700037E")]
	public override string TypeName
	{
		[Address(RVA = "0x1F0B410", Offset = "0x1F0A810", Length = "0x62")]
		[Token(Token = "0x6001D28")]
		 get { } //Length: 98
	}

	[Token(Token = "0x1700037F")]
	public override string Uri
	{
		[Address(RVA = "0x1F0A850", Offset = "0x1F09C50", Length = "0x62")]
		[Token(Token = "0x6001D29")]
		 get { } //Length: 98
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001D2A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1F0A8C0", Offset = "0x1F09CC0", Length = "0xE9")]
	[Token(Token = "0x6001D19")]
	internal MethodResponse(Exception e, IMethodCallMessage msg) { }

	[Address(RVA = "0x1F0A9B0", Offset = "0x1F09DB0", Length = "0xCD")]
	[Token(Token = "0x6001D1A")]
	internal MethodResponse(object returnValue, Object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	[Address(RVA = "0x1F0AA80", Offset = "0x1F09E80", Length = "0x436")]
	[Token(Token = "0x6001D1B")]
	internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	[Address(RVA = "0x1F00490", Offset = "0x1EFF890", Length = "0x91")]
	[Token(Token = "0x6001D1C")]
	internal MethodResponse(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F0AEC0", Offset = "0x1F0A2C0", Length = "0x12")]
	[Token(Token = "0x6001D1E")]
	public override int get_ArgCount() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001D1F")]
	public override Object[] get_Args() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001D20")]
	public override Exception get_Exception() { }

	[Address(RVA = "0x1F0AEE0", Offset = "0x1F0A2E0", Length = "0x69")]
	[Token(Token = "0x6001D21")]
	public override LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0x1F0AF50", Offset = "0x1F0A350", Length = "0x15C")]
	[Token(Token = "0x6001D22")]
	public override MethodBase get_MethodBase() { }

	[Address(RVA = "0x1F0B0B0", Offset = "0x1F0A4B0", Length = "0x62")]
	[Token(Token = "0x6001D23")]
	public override string get_MethodName() { }

	[Address(RVA = "0x1F0B120", Offset = "0x1F0A520", Length = "0xD2")]
	[Token(Token = "0x6001D24")]
	public override object get_MethodSignature() { }

	[Address(RVA = "0x1F0B200", Offset = "0x1F0A600", Length = "0x20A")]
	[Token(Token = "0x6001D25")]
	public override Object[] get_OutArgs() { }

	[Address(RVA = "0x1F00530", Offset = "0x1EFF930", Length = "0xBB")]
	[Token(Token = "0x6001D26")]
	public override IDictionary get_Properties() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001D27")]
	public override object get_ReturnValue() { }

	[Address(RVA = "0x1F0B410", Offset = "0x1F0A810", Length = "0x62")]
	[Token(Token = "0x6001D28")]
	public override string get_TypeName() { }

	[Address(RVA = "0x1F0A850", Offset = "0x1F09C50", Length = "0x62")]
	[Token(Token = "0x6001D29")]
	public override string get_Uri() { }

	[Address(RVA = "0x1F09F30", Offset = "0x1F09330", Length = "0x2D")]
	[Token(Token = "0x6001D2D")]
	public override object GetArg(int argNum) { }

	[Address(RVA = "0x1F09F60", Offset = "0x1F09360", Length = "0x375")]
	[Token(Token = "0x6001D2E")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F0A2E0", Offset = "0x1F096E0", Length = "0x56F")]
	[Token(Token = "0x6001D1D")]
	internal void InitMethodProperty(string key, object value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001D2A")]
	public void set_Uri(string value) { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6001D2F")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	[Address(RVA = "0x1F0A850", Offset = "0x1F09C50", Length = "0x62")]
	[Token(Token = "0x6001D2B")]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x6001D30")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001D2C")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

