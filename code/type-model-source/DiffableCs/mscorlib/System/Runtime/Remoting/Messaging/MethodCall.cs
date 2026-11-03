namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
[Token(Token = "0x20003BE")]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ED2")]
	private string _uri; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ED3")]
	private string _typeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ED4")]
	private string _methodName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000ED5")]
	private Object[] _args; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000ED6")]
	private Type[] _methodSignature; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000ED7")]
	private MethodBase _methodBase; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000ED8")]
	private LogicalCallContext _callContext; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000ED9")]
	private Identity _targetIdentity; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000EDA")]
	private Type[] _genericArguments; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000EDB")]
	protected IDictionary ExternalProperties; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000EDC")]
	protected IDictionary InternalProperties; //Field offset: 0x60

	[Token(Token = "0x1700035A")]
	public override int ArgCount
	{
		[Address(RVA = "0xFBEA60", Offset = "0xFBDE60", Length = "0x1A")]
		[Token(Token = "0x6001CE2")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700035B")]
	public override Object[] Args
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001CE3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000365")]
	private Type[] GenericArguments
	{
		[Address(RVA = "0x1F09BF0", Offset = "0x1F08FF0", Length = "0x68")]
		[Token(Token = "0x6001CF6")]
		private get { } //Length: 104
	}

	[Token(Token = "0x1700035C")]
	public override LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x1F09C60", Offset = "0x1F09060", Length = "0x69")]
		[Token(Token = "0x6001CE4")]
		 get { } //Length: 105
	}

	[Token(Token = "0x1700035D")]
	public override MethodBase MethodBase
	{
		[Address(RVA = "0x1F09CD0", Offset = "0x1F090D0", Length = "0x2F")]
		[Token(Token = "0x6001CE5")]
		 get { } //Length: 47
	}

	[Token(Token = "0x1700035E")]
	public override string MethodName
	{
		[Address(RVA = "0x1F09D00", Offset = "0x1F09100", Length = "0x4B")]
		[Token(Token = "0x6001CE6")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700035F")]
	public override object MethodSignature
	{
		[Address(RVA = "0x1F09D50", Offset = "0x1F09150", Length = "0x16B")]
		[Token(Token = "0x6001CE7")]
		 get { } //Length: 363
	}

	[Token(Token = "0x17000360")]
	public override IDictionary Properties
	{
		[Address(RVA = "0x1F002D0", Offset = "0x1EFF6D0", Length = "0x37")]
		[Token(Token = "0x6001CE8")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000364")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001CF4")]
		private get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6001CF5")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000363")]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001CED")]
		private get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6001CEE")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000361")]
	public override string TypeName
	{
		[Address(RVA = "0x1F09EC0", Offset = "0x1F092C0", Length = "0x67")]
		[Token(Token = "0x6001CEA")]
		 get { } //Length: 103
	}

	[Token(Token = "0x17000362")]
	public override string Uri
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001CEB")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6001CEC")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1F00060", Offset = "0x1EFF460", Length = "0xB0")]
	[Token(Token = "0x6001CDC")]
	internal MethodCall(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F098B0", Offset = "0x1F08CB0", Length = "0x333")]
	[Token(Token = "0x6001CDD")]
	internal MethodCall(CADMethodCallMessage msg) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001CDE")]
	internal MethodCall() { }

	[Address(RVA = "0x1F08440", Offset = "0x1F07840", Length = "0x1FE")]
	[Token(Token = "0x6001CF2")]
	private Type CastTo(string clientType, Type serverType) { }

	[Address(RVA = "0x1F08640", Offset = "0x1F07A40", Length = "0x1D0")]
	[Token(Token = "0x6001CDF")]
	internal void CopyFrom(IMethodMessage call) { }

	[Address(RVA = "0xFBEA60", Offset = "0xFBDE60", Length = "0x1A")]
	[Token(Token = "0x6001CE2")]
	public override int get_ArgCount() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001CE3")]
	public override Object[] get_Args() { }

	[Address(RVA = "0x1F09BF0", Offset = "0x1F08FF0", Length = "0x68")]
	[Token(Token = "0x6001CF6")]
	private Type[] get_GenericArguments() { }

	[Address(RVA = "0x1F09C60", Offset = "0x1F09060", Length = "0x69")]
	[Token(Token = "0x6001CE4")]
	public override LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0x1F09CD0", Offset = "0x1F090D0", Length = "0x2F")]
	[Token(Token = "0x6001CE5")]
	public override MethodBase get_MethodBase() { }

	[Address(RVA = "0x1F09D00", Offset = "0x1F09100", Length = "0x4B")]
	[Token(Token = "0x6001CE6")]
	public override string get_MethodName() { }

	[Address(RVA = "0x1F09D50", Offset = "0x1F09150", Length = "0x16B")]
	[Token(Token = "0x6001CE7")]
	public override object get_MethodSignature() { }

	[Address(RVA = "0x1F002D0", Offset = "0x1EFF6D0", Length = "0x37")]
	[Token(Token = "0x6001CE8")]
	public override IDictionary get_Properties() { }

	[Address(RVA = "0x1F09EC0", Offset = "0x1F092C0", Length = "0x67")]
	[Token(Token = "0x6001CEA")]
	public override string get_TypeName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001CEB")]
	public override string get_Uri() { }

	[Address(RVA = "0x1E13990", Offset = "0x1E12D90", Length = "0x2B")]
	[Token(Token = "0x6001CEF")]
	public override object GetArg(int argNum) { }

	[Address(RVA = "0x1F08820", Offset = "0x1F07C20", Length = "0x342")]
	[Token(Token = "0x6001CE1")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F08B70", Offset = "0x1F07F70", Length = "0x8E")]
	[Token(Token = "0x6001CF3")]
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001CF0")]
	public override void Init() { }

	[Address(RVA = "0x1F08C00", Offset = "0x1F08000", Length = "0xA8")]
	[Token(Token = "0x6001CE9")]
	internal override void InitDictionary() { }

	[Address(RVA = "0x1F08CB0", Offset = "0x1F080B0", Length = "0x4E3")]
	[Token(Token = "0x6001CE0")]
	internal override void InitMethodProperty(string key, object value) { }

	[Address(RVA = "0x1F091A0", Offset = "0x1F085A0", Length = "0x704")]
	[Token(Token = "0x6001CF1")]
	public void ResolveMethod() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6001CEC")]
	public void set_Uri(string value) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001CF4")]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001CED")]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6001CF5")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6001CEE")]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

