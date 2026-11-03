namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextInfo.h")]
[Token(Token = "0x200002C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule"})]
internal struct NativeTextInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000107")]
	private IntPtr m_MeshInfosPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000108")]
	public int meshInfoCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000109")]
	public int totalWidth; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400010A")]
	public int totalHeight; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400010B")]
	public bool isElided; //Field offset: 0x14

	[Token(Token = "0x17000012")]
	public Span<ATGMeshInfo> meshInfos
	{
		[Address(RVA = "0x3184A90", Offset = "0x3183E90", Length = "0x80")]
		[Token(Token = "0x600008A")]
		 get { } //Length: 128
	}

	[Address(RVA = "0x3184A90", Offset = "0x3183E90", Length = "0x80")]
	[Token(Token = "0x600008A")]
	public Span<ATGMeshInfo> get_meshInfos() { }

}

