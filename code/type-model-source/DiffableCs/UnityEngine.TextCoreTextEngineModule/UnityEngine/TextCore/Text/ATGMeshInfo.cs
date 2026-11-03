namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/ATGMeshInfo.h")]
[Token(Token = "0x2000019")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct ATGMeshInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AC")]
	private IntPtr m_TextElementInfosPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000AD")]
	private int m_TextElementCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000AE")]
	public int textAssetId; //Field offset: 0xC

	[Token(Token = "0x1700000D")]
	public Span<NativeTextElementInfo> textElementInfos
	{
		[Address(RVA = "0x3171BF0", Offset = "0x3170FF0", Length = "0x80")]
		[Token(Token = "0x600004F")]
		 get { } //Length: 128
	}

	[Address(RVA = "0x3171BF0", Offset = "0x3170FF0", Length = "0x80")]
	[Token(Token = "0x600004F")]
	public Span<NativeTextElementInfo> get_textElementInfos() { }

}

