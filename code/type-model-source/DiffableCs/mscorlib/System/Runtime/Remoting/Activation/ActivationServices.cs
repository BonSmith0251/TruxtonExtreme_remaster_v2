namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000391")]
internal class ActivationServices
{
	[Token(Token = "0x4000E7B")]
	private static IActivator _constructionActivator; //Field offset: 0x0

	[Token(Token = "0x1700030D")]
	private static IActivator ConstructionActivator
	{
		[Address(RVA = "0x1EF7CD0", Offset = "0x1EF70D0", Length = "0xA0")]
		[Token(Token = "0x6001C0D")]
		private get { } //Length: 160
	}

	[Address(RVA = "0x1EF6D10", Offset = "0x1EF6110", Length = "0x1B8")]
	[Token(Token = "0x6001C0E")]
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	[Address(RVA = "0x1EF6ED0", Offset = "0x1EF62D0", Length = "0x5")]
	[Token(Token = "0x6001C13")]
	public static object AllocateUninitializedClassInstance(Type type) { }

	[Address(RVA = "0x1EF6EE0", Offset = "0x1EF62E0", Length = "0x8A4")]
	[Token(Token = "0x6001C10")]
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, Object[] activationAttributes) { }

	[Address(RVA = "0x1EF7790", Offset = "0x1EF6B90", Length = "0x32C")]
	[Token(Token = "0x6001C11")]
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	[Address(RVA = "0x1EF7AC0", Offset = "0x1EF6EC0", Length = "0x130")]
	[Token(Token = "0x6001C12")]
	public static object CreateProxyForType(Type type) { }

	[Address(RVA = "0x1EF7C00", Offset = "0x1EF7000", Length = "0x5")]
	[Token(Token = "0x6001C14")]
	public static void EnableProxyActivation(Type type, bool enable) { }

	[Address(RVA = "0x1EF7CD0", Offset = "0x1EF70D0", Length = "0xA0")]
	[Token(Token = "0x6001C0D")]
	private static IActivator get_ConstructionActivator() { }

	[Address(RVA = "0x1EF7C10", Offset = "0x1EF7010", Length = "0xAF")]
	[Token(Token = "0x6001C0F")]
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

}

