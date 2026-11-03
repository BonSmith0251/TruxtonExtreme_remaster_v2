namespace UnityEngine.Rendering;

[Token(Token = "0x20001D4")]
public class HableCurve
{
	[Token(Token = "0x20001D6")]
	private struct DirectParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000920")]
		internal float x0; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000921")]
		internal float y0; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000922")]
		internal float x1; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000923")]
		internal float y1; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000924")]
		internal float W; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000925")]
		internal float overshootX; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000926")]
		internal float overshootY; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000927")]
		internal float gamma; //Field offset: 0x1C

	}

	[Token(Token = "0x20001D5")]
	internal class Segment
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400091A")]
		public float offsetX; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400091B")]
		public float offsetY; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400091C")]
		public float scaleX; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400091D")]
		public float scaleY; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400091E")]
		public float lnA; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400091F")]
		public float B; //Field offset: 0x24

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E3E")]
		public Segment() { }

		[Address(RVA = "0x2C648A0", Offset = "0x2C63CA0", Length = "0x42")]
		[Token(Token = "0x6000E3D")]
		public float Eval(float x) { }

	}

	[Token(Token = "0x20001D7")]
	internal class Uniforms
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000928")]
		private HableCurve parent; //Field offset: 0x10

		[Token(Token = "0x170001CF")]
		public Vector4 curve
		{
			[Address(RVA = "0x2C67F30", Offset = "0x2C67330", Length = "0x37")]
			[Token(Token = "0x6000E40")]
			 get { } //Length: 55
		}

		[Token(Token = "0x170001D2")]
		public Vector4 midSegmentA
		{
			[Address(RVA = "0x2C67F70", Offset = "0x2C67370", Length = "0x90")]
			[Token(Token = "0x6000E43")]
			 get { } //Length: 144
		}

		[Token(Token = "0x170001D3")]
		public Vector4 midSegmentB
		{
			[Address(RVA = "0x2C68010", Offset = "0x2C67410", Length = "0x63")]
			[Token(Token = "0x6000E44")]
			 get { } //Length: 99
		}

		[Token(Token = "0x170001D4")]
		public Vector4 shoSegmentA
		{
			[Address(RVA = "0x2C68080", Offset = "0x2C67480", Length = "0x90")]
			[Token(Token = "0x6000E45")]
			 get { } //Length: 144
		}

		[Token(Token = "0x170001D5")]
		public Vector4 shoSegmentB
		{
			[Address(RVA = "0x2C68120", Offset = "0x2C67520", Length = "0x63")]
			[Token(Token = "0x6000E46")]
			 get { } //Length: 99
		}

		[Token(Token = "0x170001D0")]
		public Vector4 toeSegmentA
		{
			[Address(RVA = "0x2C68190", Offset = "0x2C67590", Length = "0x90")]
			[Token(Token = "0x6000E41")]
			 get { } //Length: 144
		}

		[Token(Token = "0x170001D1")]
		public Vector4 toeSegmentB
		{
			[Address(RVA = "0x2C68230", Offset = "0x2C67630", Length = "0x63")]
			[Token(Token = "0x6000E42")]
			 get { } //Length: 99
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000E3F")]
		internal Uniforms(HableCurve parent) { }

		[Address(RVA = "0x2C67F30", Offset = "0x2C67330", Length = "0x37")]
		[Token(Token = "0x6000E40")]
		public Vector4 get_curve() { }

		[Address(RVA = "0x2C67F70", Offset = "0x2C67370", Length = "0x90")]
		[Token(Token = "0x6000E43")]
		public Vector4 get_midSegmentA() { }

		[Address(RVA = "0x2C68010", Offset = "0x2C67410", Length = "0x63")]
		[Token(Token = "0x6000E44")]
		public Vector4 get_midSegmentB() { }

		[Address(RVA = "0x2C68080", Offset = "0x2C67480", Length = "0x90")]
		[Token(Token = "0x6000E45")]
		public Vector4 get_shoSegmentA() { }

		[Address(RVA = "0x2C68120", Offset = "0x2C67520", Length = "0x63")]
		[Token(Token = "0x6000E46")]
		public Vector4 get_shoSegmentB() { }

		[Address(RVA = "0x2C68190", Offset = "0x2C67590", Length = "0x90")]
		[Token(Token = "0x6000E41")]
		public Vector4 get_toeSegmentA() { }

		[Address(RVA = "0x2C68230", Offset = "0x2C67630", Length = "0x63")]
		[Token(Token = "0x6000E42")]
		public Vector4 get_toeSegmentB() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000914")]
	private float <whitePoint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000915")]
	private float <inverseWhitePoint>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000916")]
	private float <x0>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000917")]
	private float <x1>k__BackingField; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000918")]
	public readonly Segment[] segments; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000919")]
	public readonly Uniforms uniforms; //Field offset: 0x28

	[Token(Token = "0x170001CC")]
	public private float inverseWhitePoint
	{
		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000E30")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000E31")]
		private set { } //Length: 6
	}

	[Token(Token = "0x170001CB")]
	public private float whitePoint
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000E2E")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000E2F")]
		private set { } //Length: 6
	}

	[Token(Token = "0x170001CD")]
	public private float x0
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000E32")]
		 get { } //Length: 6
		[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000E33")]
		private set { } //Length: 6
	}

	[Token(Token = "0x170001CE")]
	public private float x1
	{
		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000E34")]
		 get { } //Length: 6
		[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000E35")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x2C5ED30", Offset = "0x2C5E130", Length = "0x16C")]
	[Token(Token = "0x6000E36")]
	public HableCurve() { }

	[Address(RVA = "0x2C5E420", Offset = "0x2C5D820", Length = "0x54")]
	[Token(Token = "0x6000E3B")]
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	[Address(RVA = "0x2C5E4D0", Offset = "0x2C5D8D0", Length = "0x99")]
	[Token(Token = "0x6000E37")]
	public float Eval(float x) { }

	[Address(RVA = "0x2C5E480", Offset = "0x2C5D880", Length = "0x48")]
	[Token(Token = "0x6000E3C")]
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }

	[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000E30")]
	public float get_inverseWhitePoint() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000E2E")]
	public float get_whitePoint() { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000E32")]
	public float get_x0() { }

	[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000E34")]
	public float get_x1() { }

	[Address(RVA = "0x2C5EAB0", Offset = "0x2C5DEB0", Length = "0x209")]
	[Token(Token = "0x6000E38")]
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	[Address(RVA = "0x2C5E570", Offset = "0x2C5D970", Length = "0x53A")]
	[Token(Token = "0x6000E39")]
	private void InitSegments(DirectParams srcParams) { }

	[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000E31")]
	private void set_inverseWhitePoint(float value) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000E2F")]
	private void set_whitePoint(float value) { }

	[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000E33")]
	private void set_x0(float value) { }

	[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000E35")]
	private void set_x1(float value) { }

	[Address(RVA = "0x2C5ECC0", Offset = "0x2C5E0C0", Length = "0x6E")]
	[Token(Token = "0x6000E3A")]
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

}

