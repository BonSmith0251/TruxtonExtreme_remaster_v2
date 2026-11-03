namespace UnityEngine.Rendering;

[Token(Token = "0x20000A5")]
internal struct OccluderDerivedData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000312")]
	public Matrix4x4 viewProjMatrix; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000313")]
	public Vector4 viewOriginWorldSpace; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000314")]
	public Vector4 radialDirWorldSpace; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000315")]
	public Vector4 facingDirWorldSpace; //Field offset: 0x60

	[Address(RVA = "0x2CF9310", Offset = "0x2CF8710", Length = "0x431")]
	[Token(Token = "0x60002F9")]
	public static OccluderDerivedData FromParameters(in OccluderSubviewUpdate occluderSubviewUpdate) { }

}

