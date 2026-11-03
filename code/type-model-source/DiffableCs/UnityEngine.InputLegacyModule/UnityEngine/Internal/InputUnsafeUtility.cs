namespace UnityEngine.Internal;

[NativeHeader("Runtime/Input/InputBindings.h")]
[Token(Token = "0x200000D")]
internal static class InputUnsafeUtility
{

	[Address(RVA = "0x3110A90", Offset = "0x310FE90", Length = "0x190")]
	[NativeThrows]
	[Token(Token = "0x6000044")]
	internal static float GetAxis(string axisName) { }

	[Address(RVA = "0x3110A50", Offset = "0x310FE50", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x6000045")]
	internal static float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	[Address(RVA = "0x3110A10", Offset = "0x310FE10", Length = "0x33")]
	[Token(Token = "0x600004C")]
	private static float GetAxis_Injected(ref ManagedSpanWrapper axisName) { }

	[Address(RVA = "0x3110870", Offset = "0x310FC70", Length = "0x190")]
	[NativeThrows]
	[Token(Token = "0x6000046")]
	internal static float GetAxisRaw(string axisName) { }

	[Address(RVA = "0x3110830", Offset = "0x310FC30", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x6000047")]
	internal static float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	[Address(RVA = "0x31107F0", Offset = "0x310FBF0", Length = "0x33")]
	[Token(Token = "0x600004D")]
	private static float GetAxisRaw_Injected(ref ManagedSpanWrapper axisName) { }

	[Address(RVA = "0x3110E80", Offset = "0x3110280", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x6000048")]
	internal static bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[Address(RVA = "0x3110CB0", Offset = "0x31100B0", Length = "0x18D")]
	[NativeThrows]
	[Token(Token = "0x6000049")]
	internal static bool GetButtonDown(string buttonName) { }

	[Address(RVA = "0x3110C70", Offset = "0x3110070", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x600004A")]
	internal static byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[Address(RVA = "0x3110C30", Offset = "0x3110030", Length = "0x33")]
	[Token(Token = "0x600004E")]
	private static bool GetButtonDown_Injected(ref ManagedSpanWrapper buttonName) { }

	[Address(RVA = "0x3110E40", Offset = "0x3110240", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x600004B")]
	internal static bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[Address(RVA = "0x3110EC0", Offset = "0x31102C0", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x6000043")]
	internal static bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	[Address(RVA = "0x3110F00", Offset = "0x3110300", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x6000041")]
	internal static bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	[Address(RVA = "0x3110F40", Offset = "0x3110340", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x6000042")]
	internal static bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

}

