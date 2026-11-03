namespace UnityEngine.Rendering;

[Token(Token = "0x20003F2")]
[UsedByNativeCode]
public struct ShadowSplitData : IEquatable<ShadowSplitData>
{
	[CompilerGenerated]
	[Token(Token = "0x20003F3")]
	[UnsafeValueType]
	internal struct <m_CullingPlanes>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D10")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000D08")]
	private const int k_MaximumCullingPlaneCount = 10; //Field offset: 0x0
	[Token(Token = "0x4000D09")]
	public static readonly int maximumCullingPlaneCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D0A")]
	private int m_CullingPlaneCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[FixedBuffer(typeof(byte), 160)]
	[Token(Token = "0x4000D0B")]
	internal <m_CullingPlanes>e__FixedBuffer m_CullingPlanes; //Field offset: 0x4
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000D0C")]
	private Vector4 m_CullingSphere; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000D0D")]
	private float m_ShadowCascadeBlendCullingFactor; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000D0E")]
	private float m_CullingNearPlane; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000D0F")]
	private Matrix4x4 m_CullingMatrix; //Field offset: 0xBC

	[Token(Token = "0x1700046C")]
	public int cullingPlaneCount
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6001E88")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700046D")]
	public Vector4 cullingSphere
	{
		[Address(RVA = "0x30CD0F0", Offset = "0x30CC4F0", Length = "0xE")]
		[Token(Token = "0x6001E89")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700046E")]
	public float shadowCascadeBlendCullingFactor
	{
		[Address(RVA = "0x30CD100", Offset = "0x30CC500", Length = "0x10B")]
		[Token(Token = "0x6001E8A")]
		 set { } //Length: 267
	}

	[Address(RVA = "0x30CD0B0", Offset = "0x30CC4B0", Length = "0x39")]
	[Token(Token = "0x6001E8F")]
	private static ShadowSplitData() { }

	[Address(RVA = "0x30CCBC0", Offset = "0x30CBFC0", Length = "0x2F8")]
	[Token(Token = "0x6001E8C")]
	public override bool Equals(ShadowSplitData other) { }

	[Address(RVA = "0x30CCA60", Offset = "0x30CBE60", Length = "0x151")]
	[Token(Token = "0x6001E8D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001E88")]
	public int get_cullingPlaneCount() { }

	[Address(RVA = "0x30CD0F0", Offset = "0x30CC4F0", Length = "0xE")]
	[Token(Token = "0x6001E89")]
	public Vector4 get_cullingSphere() { }

	[Address(RVA = "0x30CCEC0", Offset = "0x30CC2C0", Length = "0x152")]
	[Token(Token = "0x6001E8B")]
	public Plane GetCullingPlane(int index) { }

	[Address(RVA = "0x30CD020", Offset = "0x30CC420", Length = "0x8A")]
	[Token(Token = "0x6001E8E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30CD100", Offset = "0x30CC500", Length = "0x10B")]
	[Token(Token = "0x6001E8A")]
	public void set_shadowCascadeBlendCullingFactor(float value) { }

}

