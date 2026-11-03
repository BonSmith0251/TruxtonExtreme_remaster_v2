namespace UnityEngine;

[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
[Token(Token = "0x20000A1")]
internal class BootConfigData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001DF")]
	private IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x2FCEF50", Offset = "0x2FCE350", Length = "0x73")]
	[Token(Token = "0x60002B3")]
	private BootConfigData(IntPtr nativeHandle) { }

	[Address(RVA = "0x2FCEEA0", Offset = "0x2FCE2A0", Length = "0xA1")]
	[RequiredByNativeCode]
	[Token(Token = "0x60002B2")]
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

}

