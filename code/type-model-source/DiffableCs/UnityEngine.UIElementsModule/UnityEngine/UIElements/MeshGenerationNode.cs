namespace UnityEngine.UIElements;

[NativeContainer]
[Token(Token = "0x20002D8")]
public struct MeshGenerationNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B96")]
	private UnsafeMeshGenerationNode m_UnsafeNode; //Field offset: 0x0

	[Address(RVA = "0x3406970", Offset = "0x3405D70", Length = "0x4")]
	[Token(Token = "0x60013C7")]
	internal static void Create(GCHandle handle, out MeshGenerationNode node) { }

	[Address(RVA = "0x3406980", Offset = "0x3405D80", Length = "0x1E")]
	[Token(Token = "0x60013C8")]
	internal Entry GetParentEntry() { }

}

