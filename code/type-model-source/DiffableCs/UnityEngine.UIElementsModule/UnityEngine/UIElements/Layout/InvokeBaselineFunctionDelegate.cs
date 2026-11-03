namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005FD")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class InvokeBaselineFunctionDelegate : MulticastDelegate
{

	[Address(RVA = "0x331BE30", Offset = "0x331B230", Length = "0xB5")]
	[Token(Token = "0x6002B34")]
	public InvokeBaselineFunctionDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x1C16FC0", Offset = "0x1C163C0", Length = "0x14")]
	[Token(Token = "0x6002B35")]
	public override float Invoke(ref LayoutNode node, float width, float height) { }

}

