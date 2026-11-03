namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x200001E")]
public class GUITargetAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B8")]
	internal int displayMask; //Field offset: 0x10

	[Address(RVA = "0x30EE9C0", Offset = "0x30EDDC0", Length = "0x187")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000171")]
	private static int GetGUITargetAttrValue(Type klass, string methodName) { }

}

