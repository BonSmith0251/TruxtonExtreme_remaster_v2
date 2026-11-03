namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000171")]
public sealed class ColorUsageAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000608")]
	public readonly bool showAlpha; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000609")]
	public readonly bool hdr; //Field offset: 0x19
	[FieldOffset(Offset = "0x1C")]
	[Obsolete("This field is no longer used for anything.")]
	[Token(Token = "0x400060A")]
	public readonly float minBrightness; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Obsolete("This field is no longer used for anything.")]
	[Token(Token = "0x400060B")]
	public readonly float maxBrightness; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Obsolete("This field is no longer used for anything.")]
	[Token(Token = "0x400060C")]
	public readonly float minExposureValue; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Obsolete("This field is no longer used for anything.")]
	[Token(Token = "0x400060D")]
	public readonly float maxExposureValue; //Field offset: 0x28

	[Address(RVA = "0x3058350", Offset = "0x3057750", Length = "0x4C")]
	[Token(Token = "0x6001208")]
	public ColorUsageAttribute(bool showAlpha) { }

}

