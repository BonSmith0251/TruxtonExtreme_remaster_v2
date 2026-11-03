namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeDataTests.h")]
[Token(Token = "0x200000B")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.AccessibilityModule"})]
internal class AccessibilityNodeDataTests
{
	[Token(Token = "0x4000040")]
	internal static AccessibilityNodeData nodeDataFromNative; //Field offset: 0x0

	[Address(RVA = "0x2F84AF0", Offset = "0x2F83EF0", Length = "0x1CA")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003F")]
	internal static void Internal_GetNodeDataFromManaged(ref AccessibilityNodeData nodeData) { }

	[Address(RVA = "0x2F84CC0", Offset = "0x2F840C0", Length = "0x6B")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000040")]
	internal static void Internal_GetNodeDataToManaged(in AccessibilityNodeData nodeData) { }

}

