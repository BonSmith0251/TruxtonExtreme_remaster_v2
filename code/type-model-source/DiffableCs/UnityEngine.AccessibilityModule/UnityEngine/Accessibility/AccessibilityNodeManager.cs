namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeManager.h")]
[Token(Token = "0x200000C")]
internal static class AccessibilityNodeManager
{

	[Address(RVA = "0x2F84E30", Offset = "0x2F84230", Length = "0x33")]
	[Token(Token = "0x6000041")]
	internal static bool CreateNativeNodeWithData(AccessibilityNodeData nodeData) { }

	[Address(RVA = "0x2F84DF0", Offset = "0x2F841F0", Length = "0x33")]
	[Token(Token = "0x600004A")]
	private static bool CreateNativeNodeWithData_Injected(in AccessibilityNodeData nodeData) { }

	[Address(RVA = "0x2F84E70", Offset = "0x2F84270", Length = "0x31")]
	[Token(Token = "0x6000042")]
	internal static void DestroyNativeNode(int nodeId) { }

	[Address(RVA = "0x2F84EB0", Offset = "0x2F842B0", Length = "0x53")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000047")]
	internal static bool Internal_InvokeDecremented(int nodeId) { }

	[Address(RVA = "0x2F84F10", Offset = "0x2F84310", Length = "0x65")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000049")]
	internal static bool Internal_InvokeDismissed(int nodeId) { }

	[Address(RVA = "0x2F84F80", Offset = "0x2F84380", Length = "0x184")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000044")]
	internal static void Internal_InvokeFocusChanged(int nodeId, bool isNodeFocused) { }

	[Address(RVA = "0x2F85110", Offset = "0x2F84510", Length = "0x53")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000046")]
	internal static bool Internal_InvokeIncremented(int nodeId) { }

	[Address(RVA = "0x2F85170", Offset = "0x2F84570", Length = "0x65")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000045")]
	internal static bool Internal_InvokeNodeInvoked(int nodeId) { }

	[Address(RVA = "0x2F851E0", Offset = "0x2F845E0", Length = "0x7A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000048")]
	internal static bool Internal_InvokeScrolled(int nodeId, AccessibilityScrollDirection direction) { }

	[Address(RVA = "0x2F852A0", Offset = "0x2F846A0", Length = "0x40")]
	[Token(Token = "0x6000043")]
	internal static void SetFrame(int nodeId, Rect frame) { }

	[Address(RVA = "0x2F85260", Offset = "0x2F84660", Length = "0x40")]
	[Token(Token = "0x600004B")]
	private static void SetFrame_Injected(int nodeId, in Rect frame) { }

}

