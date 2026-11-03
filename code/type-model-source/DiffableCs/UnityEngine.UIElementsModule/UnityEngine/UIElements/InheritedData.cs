namespace UnityEngine.UIElements;

[Token(Token = "0x20003F9")]
internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D26")]
	public Color color; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D27")]
	public Length fontSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D28")]
	public Length letterSpacing; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D29")]
	public TextShadow textShadow; //Field offset: 0x20
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D2A")]
	public EditorTextRenderingMode unityEditorTextRenderingMode; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D2B")]
	public Font unityFont; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D2C")]
	public FontDefinition unityFontDefinition; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D2D")]
	public FontStyle unityFontStyleAndWeight; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D2E")]
	public MaterialDefinition unityMaterial; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D2F")]
	public Length unityParagraphSpacing; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D30")]
	public TextAnchor unityTextAlign; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000D31")]
	public TextAutoSize unityTextAutoSize; //Field offset: 0x7C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000D32")]
	public TextGeneratorType unityTextGenerator; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000D33")]
	public Color unityTextOutlineColor; //Field offset: 0x94
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000D34")]
	public float unityTextOutlineWidth; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000D35")]
	public Visibility visibility; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000D36")]
	public WhiteSpace whiteSpace; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000D37")]
	public Length wordSpacing; //Field offset: 0xB0

	[Address(RVA = "0x326D470", Offset = "0x326C870", Length = "0x7A")]
	[Token(Token = "0x6001E35")]
	public override InheritedData Copy() { }

	[Address(RVA = "0x326D350", Offset = "0x326C750", Length = "0x11A")]
	[Token(Token = "0x6001E36")]
	public override void CopyFrom(ref InheritedData other) { }

	[Address(RVA = "0x326D4F0", Offset = "0x326C8F0", Length = "0x128")]
	[Token(Token = "0x6001E38")]
	public override bool Equals(InheritedData other) { }

	[Address(RVA = "0x326D620", Offset = "0x326CA20", Length = "0x11E")]
	[Token(Token = "0x6001E39")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x326D740", Offset = "0x326CB40", Length = "0x2DD")]
	[Token(Token = "0x6001E3A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x326DA20", Offset = "0x326CE20", Length = "0x14DD")]
	[Token(Token = "0x6001E37")]
	public static bool op_Equality(InheritedData lhs, InheritedData rhs) { }

}

