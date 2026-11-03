namespace UnityEngine.Events;

[Token(Token = "0x2000235")]
internal abstract class BaseInvokableCall
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60017B5")]
	protected BaseInvokableCall() { }

	[Address(RVA = "0x3077FA0", Offset = "0x30773A0", Length = "0x13A")]
	[Token(Token = "0x60017B6")]
	protected BaseInvokableCall(object target, MethodInfo function) { }

	[Address(RVA = "0x3077F10", Offset = "0x3077310", Length = "0x8B")]
	[Token(Token = "0x60017B9")]
	protected static bool AllowInvoke(Delegate delegate) { }

	[Token(Token = "0x60017BA")]
	public abstract bool Find(object targetObj, MethodInfo method) { }

	[Token(Token = "0x60017B7")]
	public abstract void Invoke(Object[] args) { }

	[Address(RVA = "0x7973E0", Offset = "0x7967E0", Length = "0xF0")]
	[Token(Token = "0x60017B8")]
	protected static void ThrowOnInvalidArg(object arg) { }

}

