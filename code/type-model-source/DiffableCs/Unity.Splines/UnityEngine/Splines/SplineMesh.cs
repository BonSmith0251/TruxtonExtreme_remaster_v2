namespace UnityEngine.Splines;

[Token(Token = "0x200004A")]
public static class SplineMesh
{
	[CompilerGenerated]
	[Token(Token = "0x200004D")]
	private struct <>c__DisplayClass19_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012F")]
		public ExtrudeSettings<K> settings; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000130")]
		public float segmentsPerUnit; //Field offset: 0x0

	}

	[Token(Token = "0x200004B")]
	internal interface ISplineVertexData
	{

		[Token(Token = "0x170000AA")]
		public Vector3 normal
		{
			[Token(Token = "0x60002C5")]
			 get { } //Length: 0
			[Token(Token = "0x60002C6")]
			 set { } //Length: 0
		}

		[Token(Token = "0x170000A9")]
		public Vector3 position
		{
			[Token(Token = "0x60002C3")]
			 get { } //Length: 0
			[Token(Token = "0x60002C4")]
			 set { } //Length: 0
		}

		[Token(Token = "0x170000AB")]
		public Vector2 texture
		{
			[Token(Token = "0x60002C7")]
			 get { } //Length: 0
			[Token(Token = "0x60002C8")]
			 set { } //Length: 0
		}

		[Token(Token = "0x60002C5")]
		public Vector3 get_normal() { }

		[Token(Token = "0x60002C3")]
		public Vector3 get_position() { }

		[Token(Token = "0x60002C7")]
		public Vector2 get_texture() { }

		[Token(Token = "0x60002C6")]
		public void set_normal(Vector3 value) { }

		[Token(Token = "0x60002C4")]
		public void set_position(Vector3 value) { }

		[Token(Token = "0x60002C8")]
		public void set_texture(Vector2 value) { }

	}

	[Token(Token = "0x200004C")]
	private struct VertexData : ISplineVertexData
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012C")]
		private Vector3 <position>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400012D")]
		private Vector3 <normal>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012E")]
		private Vector2 <texture>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x170000AD")]
		public override Vector3 normal
		{
			[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60002CB")]
			 get { } //Length: 19
			[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
			[CompilerGenerated]
			[Token(Token = "0x60002CC")]
			 set { } //Length: 106
		}

		[Token(Token = "0x170000AC")]
		public override Vector3 position
		{
			[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60002C9")]
			 get { } //Length: 18
			[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
			[CompilerGenerated]
			[Token(Token = "0x60002CA")]
			 set { } //Length: 15
		}

		[Token(Token = "0x170000AE")]
		public override Vector2 texture
		{
			[Address(RVA = "0xABEC50", Offset = "0xABE050", Length = "0x13")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60002CD")]
			 get { } //Length: 19
			[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60002CE")]
			 set { } //Length: 5
		}

		[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60002CB")]
		public override Vector3 get_normal() { }

		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60002C9")]
		public override Vector3 get_position() { }

		[Address(RVA = "0xABEC50", Offset = "0xABE050", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60002CD")]
		public override Vector2 get_texture() { }

		[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
		[CompilerGenerated]
		[Token(Token = "0x60002CC")]
		public override void set_normal(Vector3 value) { }

		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x60002CA")]
		public override void set_position(Vector3 value) { }

		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002CE")]
		public override void set_texture(Vector2 value) { }

	}

	[Token(Token = "0x4000126")]
	private const int k_SidesMin = 2; //Field offset: 0x0
	[Token(Token = "0x4000127")]
	private const int k_SidesMax = 2084; //Field offset: 0x0
	[Token(Token = "0x4000128")]
	private static readonly VertexAttributeDescriptor[] k_PipeVertexAttribs; //Field offset: 0x0
	[Token(Token = "0x4000129")]
	private static readonly Circle s_DefaultShape; //Field offset: 0x8
	[Token(Token = "0x400012A")]
	internal static bool s_IsConvex; //Field offset: 0x10
	[Token(Token = "0x400012B")]
	private static bool s_IsConvexComputed; //Field offset: 0x11

	[Address(RVA = "0x2E76870", Offset = "0x2E75C70", Length = "0x196")]
	[Token(Token = "0x60002C1")]
	private static SplineMesh() { }

	[Address(RVA = "0x8FD1B0", Offset = "0x8FC5B0", Length = "0x1B7")]
	[CompilerGenerated]
	[Token(Token = "0x60002C2")]
	internal static int <Extrude>g__GetSegmentCount|19_0(T spline, ref <>c__DisplayClass19_0<T, K>& unnamed_param_1) { }

	[Address(RVA = "0x8FB390", Offset = "0x8FA790", Length = "0x755")]
	[Token(Token = "0x60002B2")]
	private static void ComputeIsConvex(NativeArray<TVertex> data, float3 normal, int start, int sideCount) { }

	[Address(RVA = "0x9031B0", Offset = "0x9025B0", Length = "0xC8D")]
	[Token(Token = "0x60002BE")]
	private static void Extrude(TSplineType spline, NativeArray<TVertexType> vertices, NativeArray<TIndexType> indices, ExtrudeSettings<TShapeType> settings, int vertexArrayOffset = 0, int indicesArrayOffset = 0) { }

	[Address(RVA = "0x902A40", Offset = "0x901E40", Length = "0x22B")]
	[Token(Token = "0x60002BD")]
	public static void Extrude(TSplineType spline, NativeArray<TVertexType> vertices, NativeArray<TIndexType> indices, float radius, int sides, int segments, bool capped, float2 range) { }

	[Address(RVA = "0x8FC400", Offset = "0x8FB800", Length = "0xC11")]
	[Token(Token = "0x60002BC")]
	internal static void Extrude(IReadOnlyList<T> splines, Mesh mesh, ExtrudeSettings<K> settings, float segmentsPerUnit) { }

	[Address(RVA = "0x902FD0", Offset = "0x9023D0", Length = "0x1D4")]
	[Token(Token = "0x60002BB")]
	public static void Extrude(IReadOnlyList<T> splines, Mesh mesh, float radius, int sides, float segmentsPerUnit, bool capped, float2 range) { }

	[Address(RVA = "0x8FBF50", Offset = "0x8FB350", Length = "0x4A0")]
	[Token(Token = "0x60002BA")]
	public static bool Extrude(T spline, Mesh mesh, ExtrudeSettings<K> settings) { }

	[Address(RVA = "0x900F80", Offset = "0x900380", Length = "0x326")]
	[Token(Token = "0x60002B9")]
	public static void Extrude(T spline, Mesh mesh, float radius, int segments, bool capped, float2 range, K shape) { }

	[Address(RVA = "0x900D90", Offset = "0x900190", Length = "0x1E9")]
	[Token(Token = "0x60002B7")]
	public static void Extrude(T spline, Mesh mesh, float radius, int segments, bool capped, K shape) { }

	[Address(RVA = "0x902E30", Offset = "0x902230", Length = "0x191")]
	[Token(Token = "0x60002B6")]
	public static void Extrude(T spline, Mesh mesh, float radius, int sides, int segments, bool capped = true) { }

	[Address(RVA = "0x902C70", Offset = "0x902070", Length = "0x1B5")]
	[Token(Token = "0x60002B8")]
	public static void Extrude(T spline, Mesh mesh, float radius, int sides, int segments, bool capped, float2 range) { }

	[Address(RVA = "0x8FF2C0", Offset = "0x8FE6C0", Length = "0x968")]
	[Token(Token = "0x60002B1")]
	private static void ExtrudeRing(TSpline spline, ExtrudeSettings<TShape> settings, int segment, NativeArray<TVertex> data, int start, bool uvsAreCaps = false) { }

	[Address(RVA = "0x904040", Offset = "0x903440", Length = "0x109")]
	[Token(Token = "0x60002B5")]
	private static bool GetVertexAndIndexCount(T spline, ExtrudeSettings<K> settings, out int vertexCount, out int indexCount) { }

	[Address(RVA = "0x2E767D0", Offset = "0x2E75BD0", Length = "0x99")]
	[Token(Token = "0x60002B4")]
	public static void GetVertexAndIndexCount(int sides, int segments, bool capped, bool closed, Vector2 range, out int vertexCount, out int indexCount) { }

	[Address(RVA = "0x2E76770", Offset = "0x2E75B70", Length = "0x60")]
	[Token(Token = "0x60002B3")]
	public static bool GetVertexAndIndexCount(int sides, int segments, bool capped, bool closed, bool closeRing, out int vertexCount, out int indexCount) { }

	[Address(RVA = "0x904880", Offset = "0x903C80", Length = "0x29A")]
	[Token(Token = "0x60002BF")]
	private static void WindTris(NativeArray<UInt16> indices, T spline, ExtrudeSettings<K> settings, int vertexArrayOffset = 0, int indexArrayOffset = 0) { }

	[Address(RVA = "0x904B20", Offset = "0x903F20", Length = "0x2A1")]
	[Token(Token = "0x60002C0")]
	private static void WindTris(NativeArray<UInt32> indices, T spline, ExtrudeSettings<K> settings, int vertexArrayOffset = 0, int indexArrayOffset = 0) { }

}

