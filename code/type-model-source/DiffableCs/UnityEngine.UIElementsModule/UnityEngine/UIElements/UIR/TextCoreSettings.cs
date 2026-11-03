namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005DF")]
internal struct TextCoreSettings : IEquatable<TextCoreSettings>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400155B")]
	public Color faceColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400155C")]
	public Color outlineColor; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400155D")]
	public float outlineWidth; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400155E")]
	public Color underlayColor; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400155F")]
	public Vector2 underlayOffset; //Field offset: 0x34
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001560")]
	public float underlaySoftness; //Field offset: 0x3C

	[Address(RVA = "0x3327F00", Offset = "0x3327300", Length = "0xAB")]
	[Token(Token = "0x6002A39")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3327FB0", Offset = "0x33273B0", Length = "0x197")]
	[Token(Token = "0x6002A3A")]
	public override bool Equals(TextCoreSettings other) { }

	[Address(RVA = "0x3328150", Offset = "0x3327550", Length = "0x16E")]
	[Token(Token = "0x6002A3B")]
	public virtual int GetHashCode() { }

}

