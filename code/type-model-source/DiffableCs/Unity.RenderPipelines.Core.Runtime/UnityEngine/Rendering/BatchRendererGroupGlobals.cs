namespace UnityEngine.Rendering;

[Obsolete("BatchRendererGroupGlobals and associated cbuffer are now set automatically by Unity. Setting it manually is no longer necessary or supported. #from(2023.1)")]
[Token(Token = "0x20001AD")]
public struct BatchRendererGroupGlobals : IEquatable<BatchRendererGroupGlobals>
{
	[Token(Token = "0x4000852")]
	public const string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues"; //Field offset: 0x0
	[Token(Token = "0x4000853")]
	public static readonly int kGlobalsPropertyId; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000854")]
	public Vector4 ProbesOcclusion; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000855")]
	public Vector4 SpecCube0_HDR; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000856")]
	public Vector4 SpecCube1_HDR; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000857")]
	public SHCoefficients SHCoefficients; //Field offset: 0x30

	[Token(Token = "0x1700019A")]
	public static BatchRendererGroupGlobals Default
	{
		[Address(RVA = "0x2C3A3A0", Offset = "0x2C397A0", Length = "0x1F9")]
		[Token(Token = "0x6000CC2")]
		 get { } //Length: 505
	}

	[Address(RVA = "0x2C3A350", Offset = "0x2C39750", Length = "0x4F")]
	[Token(Token = "0x6000CC8")]
	private static BatchRendererGroupGlobals() { }

	[Address(RVA = "0x2C39EE0", Offset = "0x2C392E0", Length = "0x2DB")]
	[Token(Token = "0x6000CC3")]
	public override bool Equals(BatchRendererGroupGlobals other) { }

	[Address(RVA = "0x2C39D40", Offset = "0x2C39140", Length = "0x19D")]
	[Token(Token = "0x6000CC4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2C3A3A0", Offset = "0x2C397A0", Length = "0x1F9")]
	[Token(Token = "0x6000CC2")]
	public static BatchRendererGroupGlobals get_Default() { }

	[Address(RVA = "0x2C3A1C0", Offset = "0x2C395C0", Length = "0x188")]
	[Token(Token = "0x6000CC5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C3A5A0", Offset = "0x2C399A0", Length = "0xD2")]
	[Token(Token = "0x6000CC6")]
	public static bool op_Equality(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right) { }

	[Address(RVA = "0x2C3A680", Offset = "0x2C39A80", Length = "0xD4")]
	[Token(Token = "0x6000CC7")]
	public static bool op_Inequality(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right) { }

}

