namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000041")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct PropertyPathInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014B")]
	public readonly PropertyPath propertyPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400014C")]
	public readonly Type type; //Field offset: 0x90

	[Address(RVA = "0x32259E0", Offset = "0x3224DE0", Length = "0xA9")]
	[Token(Token = "0x6000208")]
	internal PropertyPathInfo(in PropertyPath propertyPath, Type type) { }

}

