namespace UnityEngine.Rendering;

[Token(Token = "0x2000179")]
public static class Hammersley
{
	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = False, generateCBuffer = True)]
	[Token(Token = "0x200017A")]
	private struct Hammersley2dSeq16
	{
		[CompilerGenerated]
		[Token(Token = "0x200017B")]
		[UnsafeValueType]
		internal struct <hammersley2dSeq16>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400072F")]
			public float FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[FixedBuffer(typeof(float), 64)]
		[HLSLArray(16, typeof(Vector4))]
		[Token(Token = "0x400072E")]
		public <hammersley2dSeq16>e__FixedBuffer hammersley2dSeq16; //Field offset: 0x0

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = False, generateCBuffer = True)]
	[Token(Token = "0x2000180")]
	private struct Hammersley2dSeq256
	{
		[CompilerGenerated]
		[Token(Token = "0x2000181")]
		[UnsafeValueType]
		internal struct <hammersley2dSeq256>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000735")]
			public float FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[FixedBuffer(typeof(float), 1024)]
		[HLSLArray(256, typeof(Vector4))]
		[Token(Token = "0x4000734")]
		public <hammersley2dSeq256>e__FixedBuffer hammersley2dSeq256; //Field offset: 0x0

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = False, generateCBuffer = True)]
	[Token(Token = "0x200017C")]
	private struct Hammersley2dSeq32
	{
		[CompilerGenerated]
		[Token(Token = "0x200017D")]
		[UnsafeValueType]
		internal struct <hammersley2dSeq32>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000731")]
			public float FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[FixedBuffer(typeof(float), 128)]
		[HLSLArray(32, typeof(Vector4))]
		[Token(Token = "0x4000730")]
		public <hammersley2dSeq32>e__FixedBuffer hammersley2dSeq32; //Field offset: 0x0

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = False, generateCBuffer = True)]
	[Token(Token = "0x200017E")]
	private struct Hammersley2dSeq64
	{
		[CompilerGenerated]
		[Token(Token = "0x200017F")]
		[UnsafeValueType]
		internal struct <hammersley2dSeq64>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000733")]
			public float FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[FixedBuffer(typeof(float), 256)]
		[HLSLArray(64, typeof(Vector4))]
		[Token(Token = "0x4000732")]
		public <hammersley2dSeq64>e__FixedBuffer hammersley2dSeq64; //Field offset: 0x0

	}

	[Token(Token = "0x4000726")]
	private static Single[] k_Hammersley2dSeq16; //Field offset: 0x0
	[Token(Token = "0x4000727")]
	private static Single[] k_Hammersley2dSeq32; //Field offset: 0x8
	[Token(Token = "0x4000728")]
	private static Single[] k_Hammersley2dSeq64; //Field offset: 0x10
	[Token(Token = "0x4000729")]
	private static Single[] k_Hammersley2dSeq256; //Field offset: 0x18
	[Token(Token = "0x400072A")]
	private static readonly int s_hammersley2DSeq16Id; //Field offset: 0x20
	[Token(Token = "0x400072B")]
	private static readonly int s_hammersley2DSeq32Id; //Field offset: 0x24
	[Token(Token = "0x400072C")]
	private static readonly int s_hammersley2DSeq64Id; //Field offset: 0x28
	[Token(Token = "0x400072D")]
	private static readonly int s_hammersley2DSeq256Id; //Field offset: 0x2C

	[Address(RVA = "0x2C23FE0", Offset = "0x2C233E0", Length = "0x253")]
	[Token(Token = "0x6000B88")]
	private static Hammersley() { }

	[Address(RVA = "0x2C23930", Offset = "0x2C22D30", Length = "0x13B")]
	[Token(Token = "0x6000B86")]
	public static void BindConstants(CommandBuffer cmd, ComputeShader cs) { }

	[Address(RVA = "0x2C23A70", Offset = "0x2C22E70", Length = "0x1B6")]
	[Token(Token = "0x6000B87")]
	public static void BindConstants(IComputeCommandBuffer cmd, ComputeShader cs) { }

	[Address(RVA = "0x2C23C30", Offset = "0x2C23030", Length = "0x3A2")]
	[Token(Token = "0x6000B85")]
	public static void Initialize() { }

}

