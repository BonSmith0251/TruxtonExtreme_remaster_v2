namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003CA")]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F0C")]
	private Object[] _outArgs; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F0D")]
	private Object[] _args; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F0E")]
	private LogicalCallContext _callCtx; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F0F")]
	private object _returnValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F10")]
	private string _uri; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F11")]
	private Exception _exception; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F12")]
	private MethodBase _methodBase; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F13")]
	private string _methodName; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F14")]
	private Type[] _methodSignature; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F15")]
	private string _typeName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F16")]
	private MethodReturnDictionary _properties; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000F17")]
	private Identity _targetIdentity; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000F18")]
	private ArgInfo _inArgInfo; //Field offset: 0x70

	[Token(Token = "0x17000392")]
	public override int ArgCount
	{
		[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
		[Token(Token = "0x6001D58")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000393")]
	public override Object[] Args
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001D59")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039C")]
	public override Exception Exception
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001D65")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000394")]
	public override LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x1F12D10", Offset = "0x1F12110", Length = "0x69")]
		[Token(Token = "0x6001D5A")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000395")]
	public override MethodBase MethodBase
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001D5B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000396")]
	public override string MethodName
	{
		[Address(RVA = "0x1F12D80", Offset = "0x1F12180", Length = "0x5D")]
		[Token(Token = "0x6001D5C")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000397")]
	public override object MethodSignature
	{
		[Address(RVA = "0x1F12DE0", Offset = "0x1F121E0", Length = "0x16B")]
		[Token(Token = "0x6001D5D")]
		 get { } //Length: 363
	}

	[Token(Token = "0x1700039D")]
	public override Object[] OutArgs
	{
		[Address(RVA = "0x1F12F50", Offset = "0x1F12350", Length = "0xB6")]
		[Token(Token = "0x6001D66")]
		 get { } //Length: 182
	}

	[Token(Token = "0x17000398")]
	public override IDictionary Properties
	{
		[Address(RVA = "0x1F13010", Offset = "0x1F12410", Length = "0x6D")]
		[Token(Token = "0x6001D5E")]
		 get { } //Length: 109
	}

	[Token(Token = "0x1700039E")]
	public override object ReturnValue
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001D67")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039F")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001D68")]
		private get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x6001D69")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700039B")]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001D62")]
		private get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6001D63")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000399")]
	public override string TypeName
	{
		[Address(RVA = "0x1F13080", Offset = "0x1F12480", Length = "0x79")]
		[Token(Token = "0x6001D5F")]
		 get { } //Length: 121
	}

	[Token(Token = "0x1700039A")]
	public override string Uri
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001D60")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6001D61")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1F12C00", Offset = "0x1F12000", Length = "0x110")]
	[Token(Token = "0x6001D56")]
	public ReturnMessage(object ret, Object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	[Address(RVA = "0x1F12B20", Offset = "0x1F11F20", Length = "0xD4")]
	[Token(Token = "0x6001D57")]
	public ReturnMessage(Exception e, IMethodCallMessage mcm) { }

	[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
	[Token(Token = "0x6001D58")]
	public override int get_ArgCount() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001D59")]
	public override Object[] get_Args() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001D65")]
	public override Exception get_Exception() { }

	[Address(RVA = "0x1F12D10", Offset = "0x1F12110", Length = "0x69")]
	[Token(Token = "0x6001D5A")]
	public override LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001D5B")]
	public override MethodBase get_MethodBase() { }

	[Address(RVA = "0x1F12D80", Offset = "0x1F12180", Length = "0x5D")]
	[Token(Token = "0x6001D5C")]
	public override string get_MethodName() { }

	[Address(RVA = "0x1F12DE0", Offset = "0x1F121E0", Length = "0x16B")]
	[Token(Token = "0x6001D5D")]
	public override object get_MethodSignature() { }

	[Address(RVA = "0x1F12F50", Offset = "0x1F12350", Length = "0xB6")]
	[Token(Token = "0x6001D66")]
	public override Object[] get_OutArgs() { }

	[Address(RVA = "0x1F13010", Offset = "0x1F12410", Length = "0x6D")]
	[Token(Token = "0x6001D5E")]
	public override IDictionary get_Properties() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001D67")]
	public override object get_ReturnValue() { }

	[Address(RVA = "0x1F13080", Offset = "0x1F12480", Length = "0x79")]
	[Token(Token = "0x6001D5F")]
	public override string get_TypeName() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001D60")]
	public override string get_Uri() { }

	[Address(RVA = "0x1F12AF0", Offset = "0x1F11EF0", Length = "0x2B")]
	[Token(Token = "0x6001D64")]
	public override object GetArg(int argNum) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6001D61")]
	public void set_Uri(string value) { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001D68")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001D62")]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x6001D69")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6001D63")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

