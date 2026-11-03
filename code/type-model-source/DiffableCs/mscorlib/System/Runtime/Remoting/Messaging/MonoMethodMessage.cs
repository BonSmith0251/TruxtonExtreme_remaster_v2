namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003C4")]
internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EF6")]
	private RuntimeMethodInfo method; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EF7")]
	private Object[] args; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EF8")]
	private String[] names; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EF9")]
	private Byte[] arg_types; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EFA")]
	public LogicalCallContext ctx; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EFB")]
	public object rval; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000EFC")]
	public Exception exc; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EFD")]
	private AsyncResult asyncResult; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000EFE")]
	private CallType call_type; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000EFF")]
	private string uri; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F00")]
	private MCMDictionary properties; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000F01")]
	private Identity identity; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000F02")]
	private Type[] methodSignature; //Field offset: 0x70

	[Token(Token = "0x17000383")]
	public override int ArgCount
	{
		[Address(RVA = "0x1F0C050", Offset = "0x1F0B450", Length = "0x90")]
		[Token(Token = "0x6001D39")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000384")]
	public override Object[] Args
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001D3A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000390")]
	public AsyncResult AsyncResult
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001D4A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000391")]
	internal CallType CallType
	{
		[Address(RVA = "0x1F0C0E0", Offset = "0x1F0B4E0", Length = "0x6C")]
		[Token(Token = "0x6001D4B")]
		internal get { } //Length: 108
	}

	[Token(Token = "0x1700038B")]
	public override Exception Exception
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001D44")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000385")]
	public override LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001D3B")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6001D3C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000386")]
	public override MethodBase MethodBase
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001D3D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000387")]
	public override string MethodName
	{
		[Address(RVA = "0x1F0C150", Offset = "0x1F0B550", Length = "0x59")]
		[Token(Token = "0x6001D3E")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000388")]
	public override object MethodSignature
	{
		[Address(RVA = "0x1F0C1B0", Offset = "0x1F0B5B0", Length = "0x157")]
		[Token(Token = "0x6001D3F")]
		 get { } //Length: 343
	}

	[Token(Token = "0x1700038C")]
	public override int OutArgCount
	{
		[Address(RVA = "0x1F0C310", Offset = "0x1F0B710", Length = "0x5A")]
		[Token(Token = "0x6001D45")]
		 get { } //Length: 90
	}

	[Token(Token = "0x1700038D")]
	public override Object[] OutArgs
	{
		[Address(RVA = "0x1F0C370", Offset = "0x1F0B770", Length = "0x1CD")]
		[Token(Token = "0x6001D46")]
		 get { } //Length: 461
	}

	[Token(Token = "0x17000382")]
	public override IDictionary Properties
	{
		[Address(RVA = "0x1F0C540", Offset = "0x1F0B940", Length = "0x6D")]
		[Token(Token = "0x6001D38")]
		 get { } //Length: 109
	}

	[Token(Token = "0x1700038E")]
	public override object ReturnValue
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001D47")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700038F")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001D48")]
		private get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x6001D49")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000389")]
	public override string TypeName
	{
		[Address(RVA = "0x1F0C5B0", Offset = "0x1F0B9B0", Length = "0x74")]
		[Token(Token = "0x6001D40")]
		 get { } //Length: 116
	}

	[Token(Token = "0x1700038A")]
	public override string Uri
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6001D41")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6001D42")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1F0BF80", Offset = "0x1F0B380", Length = "0xC7")]
	[Token(Token = "0x6001D34")]
	public MonoMethodMessage(MethodBase method, Object[] out_args) { }

	[Address(RVA = "0x1F0BE20", Offset = "0x1F0B220", Length = "0x153")]
	[Token(Token = "0x6001D35")]
	internal MonoMethodMessage(MethodInfo minfo, Object[] in_args, Object[] out_args) { }

	[Address(RVA = "0x1F0BC20", Offset = "0x1F0B020", Length = "0x1F3")]
	[Token(Token = "0x6001D37")]
	public MonoMethodMessage(Type type, string methodName, Object[] in_args) { }

	[Address(RVA = "0x1F0C050", Offset = "0x1F0B450", Length = "0x90")]
	[Token(Token = "0x6001D39")]
	public override int get_ArgCount() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001D3A")]
	public override Object[] get_Args() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001D4A")]
	public AsyncResult get_AsyncResult() { }

	[Address(RVA = "0x1F0C0E0", Offset = "0x1F0B4E0", Length = "0x6C")]
	[Token(Token = "0x6001D4B")]
	internal CallType get_CallType() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001D44")]
	public override Exception get_Exception() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001D3B")]
	public override LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001D3D")]
	public override MethodBase get_MethodBase() { }

	[Address(RVA = "0x1F0C150", Offset = "0x1F0B550", Length = "0x59")]
	[Token(Token = "0x6001D3E")]
	public override string get_MethodName() { }

	[Address(RVA = "0x1F0C1B0", Offset = "0x1F0B5B0", Length = "0x157")]
	[Token(Token = "0x6001D3F")]
	public override object get_MethodSignature() { }

	[Address(RVA = "0x1F0C310", Offset = "0x1F0B710", Length = "0x5A")]
	[Token(Token = "0x6001D45")]
	public override int get_OutArgCount() { }

	[Address(RVA = "0x1F0C370", Offset = "0x1F0B770", Length = "0x1CD")]
	[Token(Token = "0x6001D46")]
	public override Object[] get_OutArgs() { }

	[Address(RVA = "0x1F0C540", Offset = "0x1F0B940", Length = "0x6D")]
	[Token(Token = "0x6001D38")]
	public override IDictionary get_Properties() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001D47")]
	public override object get_ReturnValue() { }

	[Address(RVA = "0x1F0C5B0", Offset = "0x1F0B9B0", Length = "0x74")]
	[Token(Token = "0x6001D40")]
	public override string get_TypeName() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001D41")]
	public override string get_Uri() { }

	[Address(RVA = "0x1F0B770", Offset = "0x1F0AB70", Length = "0x2D")]
	[Token(Token = "0x6001D43")]
	public override object GetArg(int arg_num) { }

	[Address(RVA = "0x1F0B7A0", Offset = "0x1F0ABA0", Length = "0xBA")]
	[Token(Token = "0x6001D36")]
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	[Address(RVA = "0x1F0B860", Offset = "0x1F0AC60", Length = "0x33B")]
	[Token(Token = "0x6001D33")]
	internal void InitMessage(RuntimeMethodInfo method, Object[] out_args) { }

	[Address(RVA = "0x1F0BBA0", Offset = "0x1F0AFA0", Length = "0x72")]
	[Token(Token = "0x6001D4C")]
	public bool NeedsOutProcessing(out int outCount) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6001D3C")]
	public void set_LogicalCallContext(LogicalCallContext value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6001D42")]
	public override void set_Uri(string value) { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001D48")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x6001D49")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

