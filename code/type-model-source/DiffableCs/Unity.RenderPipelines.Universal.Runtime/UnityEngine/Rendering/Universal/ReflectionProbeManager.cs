namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000163")]
internal struct ReflectionProbeManager : IDisposable
{
	[Token(Token = "0x2000164")]
	private struct CachedProbe
	{
		[CompilerGenerated]
		[Token(Token = "0x2000165")]
		[UnsafeValueType]
		internal struct <dataIndices>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000834")]
			public int FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[Token(Token = "0x2000166")]
		[UnsafeValueType]
		internal struct <levels>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000835")]
			public int FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400082B")]
		public uint updateCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400082C")]
		public Hash128 imageContentsHash; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400082D")]
		public int size; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400082E")]
		public int mipCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[FixedBuffer(typeof(int), 7)]
		[Token(Token = "0x400082F")]
		public <dataIndices>e__FixedBuffer dataIndices; //Field offset: 0x20
		[FieldOffset(Offset = "0x3C")]
		[FixedBuffer(typeof(int), 7)]
		[Token(Token = "0x4000830")]
		public <levels>e__FixedBuffer levels; //Field offset: 0x3C
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000831")]
		public Texture texture; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000832")]
		public int lastUsed; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4000833")]
		public Vector4 hdrData; //Field offset: 0x64

	}

	[Token(Token = "0x2000167")]
	private static class ShaderProperties
	{
		[Token(Token = "0x4000836")]
		public static readonly int BoxMin; //Field offset: 0x0
		[Token(Token = "0x4000837")]
		public static readonly int BoxMax; //Field offset: 0x4
		[Token(Token = "0x4000838")]
		public static readonly int ProbePosition; //Field offset: 0x8
		[Token(Token = "0x4000839")]
		public static readonly int MipScaleOffset; //Field offset: 0xC
		[Token(Token = "0x400083A")]
		public static readonly int Count; //Field offset: 0x10
		[Token(Token = "0x400083B")]
		public static readonly int Atlas; //Field offset: 0x14
		[Token(Token = "0x400083C")]
		public static readonly int Rotation; //Field offset: 0x18

		[Address(RVA = "0x2DDD200", Offset = "0x2DDC600", Length = "0x151")]
		[Token(Token = "0x60007EC")]
		private static ShaderProperties() { }

	}

	[Token(Token = "0x4000829")]
	private const int k_MaxMipCount = 7; //Field offset: 0x0
	[Token(Token = "0x400082A")]
	private const string k_ReflectionProbeAtlasName = "URP Reflection Probe Atlas"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400081B")]
	private int2 m_Resolution; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400081C")]
	private RenderTexture m_AtlasTexture0; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400081D")]
	private RenderTexture m_AtlasTexture1; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400081E")]
	private RTHandle m_AtlasTexture0Handle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400081F")]
	private BuddyAllocator m_AtlasAllocator; //Field offset: 0x20
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000820")]
	private Dictionary<Int32, CachedProbe> m_Cache; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000821")]
	private Dictionary<Int32, Int32> m_WarningCache; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000822")]
	private List<Int32> m_NeedsUpdate; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000823")]
	private List<Int32> m_NeedsRemove; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000824")]
	private Vector4[] m_BoxMax; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000825")]
	private Vector4[] m_BoxMin; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000826")]
	private Vector4[] m_ProbePosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000827")]
	private Vector4[] m_MipScaleOffset; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000828")]
	private Vector4[] m_Rotations; //Field offset: 0x88

	[Token(Token = "0x170001DB")]
	public RenderTexture atlasRT
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x60007E5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001DC")]
	public RTHandle atlasRTHandle
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60007E6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DCCB90", Offset = "0x2DCBF90", Length = "0x42")]
	[Token(Token = "0x60007E7")]
	public static ReflectionProbeManager Create() { }

	[Address(RVA = "0x2DCCBE0", Offset = "0x2DCBFE0", Length = "0xE6")]
	[Token(Token = "0x60007EB")]
	public override void Dispose() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x60007E5")]
	public RenderTexture get_atlasRT() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60007E6")]
	public RTHandle get_atlasRTHandle() { }

	[Address(RVA = "0x2DCCCD0", Offset = "0x2DCC0D0", Length = "0x14B")]
	[Token(Token = "0x60007EA")]
	private float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip) { }

	[Address(RVA = "0x2DCCE20", Offset = "0x2DCC220", Length = "0x54F")]
	[Token(Token = "0x60007E8")]
	private void Init() { }

	[Address(RVA = "0x2DCD370", Offset = "0x2DCC770", Length = "0x220B")]
	[Token(Token = "0x60007E9")]
	public void UpdateGpuData(CommandBuffer cmd, ref CullingResults cullResults) { }

}

