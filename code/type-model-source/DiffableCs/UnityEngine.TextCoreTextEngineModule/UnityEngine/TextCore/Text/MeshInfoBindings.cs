namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/IMGUI/MeshInfo.h")]
[Token(Token = "0x2000029")]
[UsedByNativeCode("MeshInfo")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
internal struct MeshInfoBindings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F9")]
	public TextCoreVertex[] vertexData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000FA")]
	public Material material; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FB")]
	public int vertexCount; //Field offset: 0x10

}

