namespace Unity.Cinemachine;

[Token(Token = "0x2000063")]
public static class Cinemachine3OrbitRig
{
	[Token(Token = "0x2000064")]
	internal struct Orbit
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018D")]
		[Tooltip("Horizontal radius of the orbit")]
		public float Radius; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400018E")]
		[Tooltip("Height of the horizontal orbit circle, relative to the target position")]
		public float Height; //Field offset: 0x4

	}

	[Token(Token = "0x2000066")]
	public struct OrbitSplineCache
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000193")]
		private Settings OrbitSettings; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000194")]
		private Vector4[] CachedKnots; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000195")]
		private Vector4[] CachedCtrl1; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000196")]
		private Vector4[] CachedCtrl2; //Field offset: 0x30

		[Address(RVA = "0x2832B40", Offset = "0x2831F40", Length = "0x5F")]
		[Token(Token = "0x60001D0")]
		public bool SettingsChanged(in Settings other) { }

		[Address(RVA = "0x2832BA0", Offset = "0x2831FA0", Length = "0x355")]
		[Token(Token = "0x60001D2")]
		public Vector4 SplineValue(float t) { }

		[Address(RVA = "0x2832F00", Offset = "0x2832300", Length = "0x52E")]
		[Token(Token = "0x60001D1")]
		public void UpdateOrbitCache(in Settings orbits) { }

	}

	[Token(Token = "0x2000065")]
	internal struct Settings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018F")]
		[Tooltip("Value to take at the top of the axis range")]
		public Orbit Top; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000190")]
		[Tooltip("Value to take at the center of the axis range")]
		public Orbit Center; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000191")]
		[Tooltip("Value to take at the bottom of the axis range")]
		public Orbit Bottom; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Range(0, 1)]
		[Token(Token = "0x4000192")]
		[Tooltip("Controls how taut is the line that connects the rigs' orbits, which determines final placement on the Y axis")]
		public float SplineCurvature; //Field offset: 0x18

		[Token(Token = "0x1700004D")]
		public static Settings Default
		{
			[Address(RVA = "0x2833580", Offset = "0x2832980", Length = "0x52")]
			[Token(Token = "0x60001CF")]
			 get { } //Length: 82
		}

		[Address(RVA = "0x2833580", Offset = "0x2832980", Length = "0x52")]
		[Token(Token = "0x60001CF")]
		public static Settings get_Default() { }

	}


}

