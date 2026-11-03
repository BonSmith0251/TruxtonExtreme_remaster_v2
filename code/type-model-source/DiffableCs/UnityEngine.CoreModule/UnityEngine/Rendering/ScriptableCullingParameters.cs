namespace UnityEngine.Rendering;

[Token(Token = "0x20003CE")]
[UsedByNativeCode]
public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters>
{
	[CompilerGenerated]
	[Token(Token = "0x20003CF")]
	[UnsafeValueType]
	internal struct <m_CullingPlanes>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C67")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20003D0")]
	[UnsafeValueType]
	internal struct <m_LayerFarCullDistances>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C68")]
		public float FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000C4B")]
	private const int k_MaximumCullingPlaneCount = 10; //Field offset: 0x0
	[Token(Token = "0x4000C4C")]
	public static readonly int maximumCullingPlaneCount; //Field offset: 0x0
	[Token(Token = "0x4000C52")]
	private const int k_LayerCount = 32; //Field offset: 0x0
	[Token(Token = "0x4000C60")]
	private const int k_CullingJobCountUpperLimit = 16; //Field offset: 0x0
	[Token(Token = "0x4000C5F")]
	private const int k_CullingJobCountLowerLimit = 1; //Field offset: 0x0
	[Token(Token = "0x4000C53")]
	public static readonly int layerCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C4A")]
	private LODParameters m_LODParameters; //Field offset: 0x0
	[FieldOffset(Offset = "0x1C")]
	[FixedBuffer(typeof(byte), 160)]
	[Token(Token = "0x4000C4D")]
	internal <m_CullingPlanes>e__FixedBuffer m_CullingPlanes; //Field offset: 0x1C
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000C4E")]
	private int m_CullingPlaneCount; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000C4F")]
	private uint m_CullingMask; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000C50")]
	private ulong m_SceneMask; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000C51")]
	private ulong m_ViewID; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[FixedBuffer(typeof(float), 32)]
	[Token(Token = "0x4000C54")]
	internal <m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; //Field offset: 0xD8
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000C55")]
	private int m_LayerCull; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000C56")]
	private Matrix4x4 m_CullingMatrix; //Field offset: 0x15C
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4000C57")]
	private Vector3 m_Origin; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000C58")]
	private float m_ShadowDistance; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x4000C59")]
	private float m_ShadowNearPlaneOffset; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000C5A")]
	private CullingOptions m_CullingOptions; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4000C5B")]
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000C5C")]
	private CameraProperties m_CameraProperties; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x59C")]
	[Token(Token = "0x4000C5D")]
	private float m_AccurateOcclusionThreshold; //Field offset: 0x59C
	[FieldOffset(Offset = "0x5A0")]
	[Token(Token = "0x4000C5E")]
	private int m_MaximumPortalCullingJobs; //Field offset: 0x5A0
	[FieldOffset(Offset = "0x5A4")]
	[Token(Token = "0x4000C61")]
	private Matrix4x4 m_StereoViewMatrix; //Field offset: 0x5A4
	[FieldOffset(Offset = "0x5E4")]
	[Token(Token = "0x4000C62")]
	private Matrix4x4 m_StereoProjectionMatrix; //Field offset: 0x5E4
	[FieldOffset(Offset = "0x624")]
	[Token(Token = "0x4000C63")]
	private float m_StereoSeparationDistance; //Field offset: 0x624
	[FieldOffset(Offset = "0x628")]
	[Token(Token = "0x4000C64")]
	private int m_maximumVisibleLights; //Field offset: 0x628
	[FieldOffset(Offset = "0x62C")]
	[Token(Token = "0x4000C65")]
	private bool m_ConservativeEnclosingSphere; //Field offset: 0x62C
	[FieldOffset(Offset = "0x630")]
	[Token(Token = "0x4000C66")]
	private int m_NumIterationsEnclosingSphere; //Field offset: 0x630

	[Token(Token = "0x17000411")]
	public bool conservativeEnclosingSphere
	{
		[Address(RVA = "0x30C8CE0", Offset = "0x30C80E0", Length = "0x7")]
		[Token(Token = "0x6001D68")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000416")]
	public CullingOptions cullingOptions
	{
		[Address(RVA = "0x30C8C90", Offset = "0x30C8090", Length = "0x9")]
		[Token(Token = "0x6001D6D")]
		 get { } //Length: 9
		[Address(RVA = "0x1CDAF40", Offset = "0x1CDA340", Length = "0x7")]
		[Token(Token = "0x6001D6E")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000413")]
	public int cullingPlaneCount
	{
		[Address(RVA = "0x30C8CA0", Offset = "0x30C80A0", Length = "0x9")]
		[Token(Token = "0x6001D6A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000414")]
	public bool isOrthographic
	{
		[Address(RVA = "0x30C0410", Offset = "0x30BF810", Length = "0x58")]
		[Token(Token = "0x6001D6B")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000410")]
	public int maximumVisibleLights
	{
		[Address(RVA = "0x30C8CF0", Offset = "0x30C80F0", Length = "0x7")]
		[Token(Token = "0x6001D67")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000412")]
	public int numIterationsEnclosingSphere
	{
		[Address(RVA = "0x30C8D00", Offset = "0x30C8100", Length = "0x7")]
		[Token(Token = "0x6001D69")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000417")]
	public ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
	{
		[Address(RVA = "0x30C8D10", Offset = "0x30C8110", Length = "0x7")]
		[Token(Token = "0x6001D6F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000415")]
	public float shadowDistance
	{
		[Address(RVA = "0x30C8D20", Offset = "0x30C8120", Length = "0x9")]
		[Token(Token = "0x6001D6C")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000419")]
	public Matrix4x4 stereoProjectionMatrix
	{
		[Address(RVA = "0x30C8CB0", Offset = "0x30C80B0", Length = "0x2F")]
		[Token(Token = "0x6001D71")]
		 get { } //Length: 47
		[Address(RVA = "0x30C8D30", Offset = "0x30C8130", Length = "0x2C")]
		[Token(Token = "0x6001D72")]
		 set { } //Length: 44
	}

	[Token(Token = "0x1700041A")]
	public float stereoSeparationDistance
	{
		[Address(RVA = "0x30C8D60", Offset = "0x30C8160", Length = "0x9")]
		[Token(Token = "0x6001D73")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000418")]
	public Matrix4x4 stereoViewMatrix
	{
		[Address(RVA = "0x30C8D70", Offset = "0x30C8170", Length = "0x2C")]
		[Token(Token = "0x6001D70")]
		 set { } //Length: 44
	}

	[Address(RVA = "0x30C8C40", Offset = "0x30C8040", Length = "0x4E")]
	[Token(Token = "0x6001D79")]
	private static ScriptableCullingParameters() { }

	[Address(RVA = "0x30C8720", Offset = "0x30C7B20", Length = "0xC2")]
	[Token(Token = "0x6001D77")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30C80A0", Offset = "0x30C74A0", Length = "0x67E")]
	[Token(Token = "0x6001D76")]
	public override bool Equals(ScriptableCullingParameters other) { }

	[Address(RVA = "0x30C8C90", Offset = "0x30C8090", Length = "0x9")]
	[Token(Token = "0x6001D6D")]
	public CullingOptions get_cullingOptions() { }

	[Address(RVA = "0x30C8CA0", Offset = "0x30C80A0", Length = "0x9")]
	[Token(Token = "0x6001D6A")]
	public int get_cullingPlaneCount() { }

	[Address(RVA = "0x30C8CB0", Offset = "0x30C80B0", Length = "0x2F")]
	[Token(Token = "0x6001D71")]
	public Matrix4x4 get_stereoProjectionMatrix() { }

	[Address(RVA = "0x30C87F0", Offset = "0x30C7BF0", Length = "0x139")]
	[Token(Token = "0x6001D75")]
	public Plane GetCullingPlane(int index) { }

	[Address(RVA = "0x30C8930", Offset = "0x30C7D30", Length = "0x217")]
	[Token(Token = "0x6001D78")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30C8B50", Offset = "0x30C7F50", Length = "0xE4")]
	[Token(Token = "0x6001D74")]
	public float GetLayerCullingDistance(int layerIndex) { }

	[Address(RVA = "0x30C8CE0", Offset = "0x30C80E0", Length = "0x7")]
	[Token(Token = "0x6001D68")]
	public void set_conservativeEnclosingSphere(bool value) { }

	[Address(RVA = "0x1CDAF40", Offset = "0x1CDA340", Length = "0x7")]
	[Token(Token = "0x6001D6E")]
	public void set_cullingOptions(CullingOptions value) { }

	[Address(RVA = "0x30C0410", Offset = "0x30BF810", Length = "0x58")]
	[Token(Token = "0x6001D6B")]
	public void set_isOrthographic(bool value) { }

	[Address(RVA = "0x30C8CF0", Offset = "0x30C80F0", Length = "0x7")]
	[Token(Token = "0x6001D67")]
	public void set_maximumVisibleLights(int value) { }

	[Address(RVA = "0x30C8D00", Offset = "0x30C8100", Length = "0x7")]
	[Token(Token = "0x6001D69")]
	public void set_numIterationsEnclosingSphere(int value) { }

	[Address(RVA = "0x30C8D10", Offset = "0x30C8110", Length = "0x7")]
	[Token(Token = "0x6001D6F")]
	public void set_reflectionProbeSortingCriteria(ReflectionProbeSortingCriteria value) { }

	[Address(RVA = "0x30C8D20", Offset = "0x30C8120", Length = "0x9")]
	[Token(Token = "0x6001D6C")]
	public void set_shadowDistance(float value) { }

	[Address(RVA = "0x30C8D30", Offset = "0x30C8130", Length = "0x2C")]
	[Token(Token = "0x6001D72")]
	public void set_stereoProjectionMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x30C8D60", Offset = "0x30C8160", Length = "0x9")]
	[Token(Token = "0x6001D73")]
	public void set_stereoSeparationDistance(float value) { }

	[Address(RVA = "0x30C8D70", Offset = "0x30C8170", Length = "0x2C")]
	[Token(Token = "0x6001D70")]
	public void set_stereoViewMatrix(Matrix4x4 value) { }

}

