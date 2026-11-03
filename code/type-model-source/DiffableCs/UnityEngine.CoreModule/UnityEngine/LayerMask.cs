namespace UnityEngine;

[NativeClass("BitField", "struct BitField;")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[NativeHeader("Runtime/BaseClasses/BitField.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20001B3")]
public struct LayerMask
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_Bits")]
	[Token(Token = "0x400067E")]
	private int m_Mask; //Field offset: 0x0

	[Token(Token = "0x170002ED")]
	public int value
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x60013AD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x60013AD")]
	public int get_value() { }

	[Address(RVA = "0x3065810", Offset = "0x3064C10", Length = "0x18C")]
	[NativeMethod("StringToLayer")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x60013AE")]
	public static int NameToLayer(string layerName) { }

	[Address(RVA = "0x30657D0", Offset = "0x3064BD0", Length = "0x33")]
	[Token(Token = "0x60013AF")]
	private static int NameToLayer_Injected(ref ManagedSpanWrapper layerName) { }

	[Address(RVA = "0x30659A0", Offset = "0x3064DA0", Length = "0x5")]
	[Token(Token = "0x60013AB")]
	public static int op_Implicit(LayerMask mask) { }

	[Address(RVA = "0x30659A0", Offset = "0x3064DA0", Length = "0x5")]
	[Token(Token = "0x60013AC")]
	public static LayerMask op_Implicit(int intVal) { }

}

