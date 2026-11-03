namespace UnityEngine.Rendering.Universal;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.Universal", "Unity.RenderPipelines.Universal.Runtime", null)]
[Token(Token = "0x200002D")]
public struct Light2DBlendStyle
{
	[Token(Token = "0x2000031")]
	public struct BlendFactors
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FE")]
		public float multiplicative; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000FF")]
		public float additive; //Field offset: 0x4

	}

	[Token(Token = "0x2000030")]
	public enum BlendMode : int
	{
		Additive = 0,
		Multiply = 1,
		Subtractive = 2,
	}

	[Token(Token = "0x200002F")]
	public struct MaskChannelFilter
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F8")]
		private Vector4 <mask>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F9")]
		private Vector4 <inverted>k__BackingField; //Field offset: 0x10

		[Token(Token = "0x1700003B")]
		public private Vector4 inverted
		{
			[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000145")]
			 get { } //Length: 11
			[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000146")]
			private set { } //Length: 8
		}

		[Token(Token = "0x1700003A")]
		public private Vector4 mask
		{
			[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000143")]
			 get { } //Length: 10
			[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6000144")]
			private set { } //Length: 7
		}

		[Address(RVA = "0x648E10", Offset = "0x648210", Length = "0xF")]
		[Token(Token = "0x6000147")]
		public MaskChannelFilter(Vector4 m, Vector4 i) { }

		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000145")]
		public Vector4 get_inverted() { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000143")]
		public Vector4 get_mask() { }

		[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000146")]
		private void set_inverted(Vector4 value) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000144")]
		private void set_mask(Vector4 value) { }

	}

	[Token(Token = "0x200002E")]
	public enum TextureChannel : int
	{
		None = 0,
		R = 1,
		G = 2,
		B = 3,
		A = 4,
		OneMinusR = 5,
		OneMinusG = 6,
		OneMinusB = 7,
		OneMinusA = 8,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000EB")]
	public string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40000EC")]
	internal TextureChannel maskTextureChannel; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x40000ED")]
	internal BlendMode blendMode; //Field offset: 0xC

	[Token(Token = "0x17000038")]
	internal Vector2 blendFactors
	{
		[Address(RVA = "0x2D214C0", Offset = "0x2D208C0", Length = "0x4D")]
		[Token(Token = "0x6000141")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x17000039")]
	internal MaskChannelFilter maskTextureChannelFilter
	{
		[Address(RVA = "0x2D21510", Offset = "0x2D20910", Length = "0x20")]
		[Token(Token = "0x6000142")]
		internal get { } //Length: 32
	}

	[Address(RVA = "0x2D214C0", Offset = "0x2D208C0", Length = "0x4D")]
	[Token(Token = "0x6000141")]
	internal Vector2 get_blendFactors() { }

	[Address(RVA = "0x2D21510", Offset = "0x2D20910", Length = "0x20")]
	[Token(Token = "0x6000142")]
	internal MaskChannelFilter get_maskTextureChannelFilter() { }

}

