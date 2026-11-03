namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005FE")]
internal static class LayoutDelegates
{
	[Token(Token = "0x40015E7")]
	private static readonly ProfilerMarker s_InvokeMeasureFunctionMarker; //Field offset: 0x0
	[Token(Token = "0x40015E8")]
	private static readonly ProfilerMarker s_InvokeBaselineFunctionMarker; //Field offset: 0x8
	[Token(Token = "0x40015E9")]
	private static readonly InvokeMeasureFunctionDelegate s_InvokeMeasureDelegate; //Field offset: 0x10
	[Token(Token = "0x40015EA")]
	private static readonly InvokeBaselineFunctionDelegate s_InvokeBaselineDelegate; //Field offset: 0x18
	[Token(Token = "0x40015EB")]
	internal static readonly IntPtr s_InvokeMeasureFunction; //Field offset: 0x20
	[Token(Token = "0x40015EC")]
	internal static readonly IntPtr s_InvokeBaselineFunction; //Field offset: 0x28

	[Address(RVA = "0x331E220", Offset = "0x331D620", Length = "0x318")]
	[Token(Token = "0x6002B38")]
	private static LayoutDelegates() { }

	[Address(RVA = "0x331DD70", Offset = "0x331D170", Length = "0x226")]
	[MonoPInvokeCallback(typeof(InvokeBaselineFunctionDelegate))]
	[Token(Token = "0x6002B37")]
	private static float InvokeBaselineFunction(ref LayoutNode node, float width, float height) { }

	[Address(RVA = "0x331DFA0", Offset = "0x331D3A0", Length = "0x272")]
	[MonoPInvokeCallback(typeof(InvokeMeasureFunctionDelegate))]
	[Token(Token = "0x6002B36")]
	private static void InvokeMeasureFunction(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result) { }

}

