namespace UnityEngine.UIElements;

[Token(Token = "0x20002D4")]
public class MeshWriteData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B7E")]
	internal NativeSlice<Vertex> m_Vertices; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B7F")]
	internal NativeSlice<UInt16> m_Indices; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B80")]
	internal int currentIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B81")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int currentVertex; //Field offset: 0x34

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60013AA")]
	internal MeshWriteData() { }

}

