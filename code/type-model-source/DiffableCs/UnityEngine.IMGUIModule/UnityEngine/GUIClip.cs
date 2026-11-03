namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIState.h")]
[NativeHeader("Modules/IMGUI/GUIClip.h")]
[Token(Token = "0x200000A")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal sealed class GUIClip
{
	[Token(Token = "0x200000B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
	public struct ParentClipScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		private bool m_Disposed; //Field offset: 0x0

		[Address(RVA = "0x30F6F20", Offset = "0x30F6320", Length = "0x8D")]
		[Token(Token = "0x6000095")]
		public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect) { }

		[Address(RVA = "0x30F6EE0", Offset = "0x30F62E0", Length = "0x37")]
		[Token(Token = "0x6000096")]
		public override void Dispose() { }

	}


	[Token(Token = "0x1700002C")]
	internal static Rect visibleRect
	{
		[Address(RVA = "0x30DFA40", Offset = "0x30DEE40", Length = "0x3C")]
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
		[Token(Token = "0x6000086")]
		internal get { } //Length: 60
	}

	[Address(RVA = "0x30DFA40", Offset = "0x30DEE40", Length = "0x3C")]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
	[Token(Token = "0x6000086")]
	internal static Rect get_visibleRect() { }

	[Address(RVA = "0x30DFA00", Offset = "0x30DEE00", Length = "0x33")]
	[Token(Token = "0x6000090")]
	private static void get_visibleRect_Injected(out Rect ret) { }

	[Address(RVA = "0x30DF620", Offset = "0x30DEA20", Length = "0x48")]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	[Token(Token = "0x600008A")]
	internal static Matrix4x4 GetMatrix() { }

	[Address(RVA = "0x30DF5E0", Offset = "0x30DE9E0", Length = "0x33")]
	[Token(Token = "0x6000092")]
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	[Address(RVA = "0x30DF670", Offset = "0x30DEA70", Length = "0x2A")]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	[Token(Token = "0x6000089")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int Internal_GetCount() { }

	[Address(RVA = "0x30DF6D0", Offset = "0x30DEAD0", Length = "0x2A")]
	[Token(Token = "0x6000088")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void Internal_Pop() { }

	[Address(RVA = "0x30DF6A0", Offset = "0x30DEAA0", Length = "0x2A")]
	[Token(Token = "0x600008E")]
	internal static void Internal_PopParentClip() { }

	[Address(RVA = "0x30DF8C0", Offset = "0x30DECC0", Length = "0x58")]
	[Token(Token = "0x6000087")]
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[Address(RVA = "0x30DF850", Offset = "0x30DEC50", Length = "0x64")]
	[Token(Token = "0x6000091")]
	private static void Internal_Push_Injected(in Rect screenRect, in Vector2 scrollOffset, in Vector2 renderOffset, bool resetOffset) { }

	[Address(RVA = "0x30DF760", Offset = "0x30DEB60", Length = "0x89")]
	[Token(Token = "0x600008C")]
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[Address(RVA = "0x30DF7F0", Offset = "0x30DEBF0", Length = "0x52")]
	[Token(Token = "0x600008D")]
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	[Address(RVA = "0x30DF700", Offset = "0x30DEB00", Length = "0x52")]
	[Token(Token = "0x6000094")]
	private static void Internal_PushParentClip_Injected(in Matrix4x4 renderTransform, in Matrix4x4 inputTransform, in Rect clipRect) { }

	[Address(RVA = "0x30DF920", Offset = "0x30DED20", Length = "0x56")]
	[Token(Token = "0x600008F")]
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[Address(RVA = "0x30DF9C0", Offset = "0x30DEDC0", Length = "0x33")]
	[Token(Token = "0x600008B")]
	internal static void SetMatrix(Matrix4x4 m) { }

	[Address(RVA = "0x30DF980", Offset = "0x30DED80", Length = "0x33")]
	[Token(Token = "0x6000093")]
	private static void SetMatrix_Injected(in Matrix4x4 m) { }

}

