namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005FC")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class InvokeMeasureFunctionDelegate : MulticastDelegate
{

	[Address(RVA = "0x331BF10", Offset = "0x331B310", Length = "0xB5")]
	[Token(Token = "0x6002B32")]
	public InvokeMeasureFunctionDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x331BEF0", Offset = "0x331B2F0", Length = "0x14")]
	[Token(Token = "0x6002B33")]
	public override void Invoke(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result) { }

}

