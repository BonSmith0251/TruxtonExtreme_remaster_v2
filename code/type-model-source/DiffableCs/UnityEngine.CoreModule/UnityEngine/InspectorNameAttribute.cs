namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000169")]
[UsedByNativeCode]
public class InspectorNameAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005FE")]
	public readonly string displayName; //Field offset: 0x18

	[Address(RVA = "0x3065720", Offset = "0x3064B20", Length = "0x35")]
	[Token(Token = "0x60011FF")]
	public InspectorNameAttribute(string displayName) { }

}

