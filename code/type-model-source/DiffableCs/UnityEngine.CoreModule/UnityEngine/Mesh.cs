namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x200012B")]
public sealed class Mesh : object
{
	[Token(Token = "0x200012C")]
	[UsedByNativeCode]
	internal struct LodSelectionCurve
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x40003E2")]
		private float m_LodSlope; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Token(Token = "0x40003E3")]
		private float m_LodBias; //Field offset: 0x4

	}

	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[StaticAccessor("MeshDataBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x200012D")]
	internal struct MeshData
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003E4")]
		internal IntPtr m_Ptr; //Field offset: 0x0

		[Token(Token = "0x170001F7")]
		public int subMeshCount
		{
			[Address(RVA = "0x3021D90", Offset = "0x3021190", Length = "0x40")]
			[Token(Token = "0x6000D2D")]
			 set { } //Length: 64
		}

		[Token(Token = "0x170001F6")]
		public int vertexBufferCount
		{
			[Address(RVA = "0x3021D50", Offset = "0x3021150", Length = "0x33")]
			[Token(Token = "0x6000D28")]
			 get { } //Length: 51
		}

		[Address(RVA = "0x3021D50", Offset = "0x3021150", Length = "0x33")]
		[Token(Token = "0x6000D28")]
		public int get_vertexBufferCount() { }

		[Address(RVA = "0x9F24E0", Offset = "0x9F18E0", Length = "0x12B")]
		[Token(Token = "0x6000D2C")]
		public NativeArray<T> GetIndexData() { }

		[Address(RVA = "0x30217E0", Offset = "0x3020BE0", Length = "0x33")]
		[NativeMethod(IsThreadSafe = True)]
		[Token(Token = "0x6000D22")]
		private static IntPtr GetIndexDataPtr(IntPtr self) { }

		[Address(RVA = "0x3021820", Offset = "0x3020C20", Length = "0x33")]
		[NativeMethod(IsThreadSafe = True)]
		[Token(Token = "0x6000D23")]
		private static ulong GetIndexDataSize(IntPtr self) { }

		[Address(RVA = "0x3021860", Offset = "0x3020C60", Length = "0x33")]
		[NativeMethod(IsThreadSafe = True)]
		[Token(Token = "0x6000D1F")]
		private static int GetVertexBufferCount(IntPtr self) { }

		[Address(RVA = "0x9F2740", Offset = "0x9F1B40", Length = "0x23A")]
		[Token(Token = "0x6000D29")]
		public NativeArray<T> GetVertexData(int stream = 0) { }

		[Address(RVA = "0x30218A0", Offset = "0x3020CA0", Length = "0x40")]
		[NativeMethod(IsThreadSafe = True)]
		[Token(Token = "0x6000D20")]
		private static IntPtr GetVertexDataPtr(IntPtr self, int stream) { }

		[Address(RVA = "0x30218E0", Offset = "0x3020CE0", Length = "0x40")]
		[NativeMethod(IsThreadSafe = True)]
		[Token(Token = "0x6000D21")]
		private static ulong GetVertexDataSize(IntPtr self, int stream) { }

		[Address(RVA = "0x3021D90", Offset = "0x3021190", Length = "0x40")]
		[Token(Token = "0x6000D2D")]
		public void set_subMeshCount(int value) { }

		[Address(RVA = "0x3021970", Offset = "0x3020D70", Length = "0x50")]
		[Token(Token = "0x6000D2B")]
		public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

		[Address(RVA = "0x3021920", Offset = "0x3020D20", Length = "0x50")]
		[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
		[Token(Token = "0x6000D25")]
		private static void SetIndexBufferParamsImpl(IntPtr self, int indexCount, IndexFormat indexFormat) { }

		[Address(RVA = "0x3021AC0", Offset = "0x3020EC0", Length = "0x72")]
		[Token(Token = "0x6000D2E")]
		public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

		[Address(RVA = "0x30219C0", Offset = "0x3020DC0", Length = "0x40")]
		[NativeMethod(IsThreadSafe = True)]
		[Token(Token = "0x6000D26")]
		private static void SetSubMeshCount(IntPtr self, int count) { }

		[Address(RVA = "0x3021A60", Offset = "0x3020E60", Length = "0x60")]
		[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
		[Token(Token = "0x6000D27")]
		private static void SetSubMeshImpl(IntPtr self, int index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

		[Address(RVA = "0x3021A00", Offset = "0x3020E00", Length = "0x60")]
		[Token(Token = "0x6000D30")]
		private static void SetSubMeshImpl_Injected(IntPtr self, int index, in SubMeshDescriptor desc, MeshUpdateFlags flags) { }

		[Address(RVA = "0x3021C70", Offset = "0x3021070", Length = "0xD9")]
		[Token(Token = "0x6000D2A")]
		public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

		[Address(RVA = "0x3021B90", Offset = "0x3020F90", Length = "0xD9")]
		[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
		[Token(Token = "0x6000D24")]
		private static void SetVertexBufferParamsFromArray(IntPtr self, int vertexCount, VertexAttributeDescriptor[] attributes) { }

		[Address(RVA = "0x3021B40", Offset = "0x3020F40", Length = "0x50")]
		[Token(Token = "0x6000D2F")]
		private static void SetVertexBufferParamsFromArray_Injected(IntPtr self, int vertexCount, ref ManagedSpanWrapper attributes) { }

	}

	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[StaticAccessor("MeshDataArrayBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x200012E")]
	internal struct MeshDataArray : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003E5")]
		internal IntPtr* m_Ptrs; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003E6")]
		internal int m_Length; //Field offset: 0x8

		[Token(Token = "0x170001F9")]
		public MeshData Item
		{
			[Address(RVA = "0x30217D0", Offset = "0x3020BD0", Length = "0xD")]
			[Token(Token = "0x6000D3A")]
			 get { } //Length: 13
		}

		[Token(Token = "0x170001F8")]
		public int Length
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x6000D39")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x3021000", Offset = "0x3020400", Length = "0x32F")]
		[Token(Token = "0x6000D3E")]
		internal MeshDataArray(Mesh mesh, bool checkReadWrite = true, bool createAsCopy = false) { }

		[Address(RVA = "0x3021450", Offset = "0x3020850", Length = "0x37F")]
		[Token(Token = "0x6000D3F")]
		internal MeshDataArray(Mesh[] meshes, int meshesCount, bool checkReadWrite = true, bool createAsCopy = false) { }

		[Address(RVA = "0x3021330", Offset = "0x3020730", Length = "0x116")]
		[Token(Token = "0x6000D40")]
		internal MeshDataArray(int meshesCount) { }

		[Address(RVA = "0x3020520", Offset = "0x301F920", Length = "0xAA")]
		[Token(Token = "0x6000D33")]
		private static void AcquireMeshDataCopy(Mesh mesh, IntPtr* datas) { }

		[Address(RVA = "0x30204D0", Offset = "0x301F8D0", Length = "0x42")]
		[Token(Token = "0x6000D43")]
		private static void AcquireMeshDataCopy_Injected(IntPtr mesh, IntPtr* datas) { }

		[Address(RVA = "0x3020630", Offset = "0x301FA30", Length = "0x84")]
		[Token(Token = "0x6000D34")]
		private static void AcquireMeshDatasCopy(Mesh[] meshes, IntPtr* datas, int count) { }

		[Address(RVA = "0x30205D0", Offset = "0x301F9D0", Length = "0x52")]
		[Token(Token = "0x6000D44")]
		private static void AcquireMeshDatasCopy_Injected(Mesh[] meshes, IntPtr* datas, int count) { }

		[Address(RVA = "0x3020710", Offset = "0x301FB10", Length = "0xAA")]
		[Token(Token = "0x6000D31")]
		private static void AcquireReadOnlyMeshData(Mesh mesh, IntPtr* datas) { }

		[Address(RVA = "0x30206C0", Offset = "0x301FAC0", Length = "0x42")]
		[Token(Token = "0x6000D41")]
		private static void AcquireReadOnlyMeshData_Injected(IntPtr mesh, IntPtr* datas) { }

		[Address(RVA = "0x3020820", Offset = "0x301FC20", Length = "0x84")]
		[Token(Token = "0x6000D32")]
		private static void AcquireReadOnlyMeshDatas(Mesh[] meshes, IntPtr* datas, int count) { }

		[Address(RVA = "0x30207C0", Offset = "0x301FBC0", Length = "0x52")]
		[Token(Token = "0x6000D42")]
		private static void AcquireReadOnlyMeshDatas_Injected(Mesh[] meshes, IntPtr* datas, int count) { }

		[Address(RVA = "0x30208B0", Offset = "0x301FCB0", Length = "0x1A4")]
		[Token(Token = "0x6000D3C")]
		internal void ApplyToMeshAndDispose(Mesh mesh, MeshUpdateFlags flags) { }

		[Address(RVA = "0x3020B80", Offset = "0x301FF80", Length = "0x25B")]
		[Token(Token = "0x6000D3D")]
		internal void ApplyToMeshesAndDispose(Mesh[] meshes, MeshUpdateFlags flags) { }

		[Address(RVA = "0x3020E50", Offset = "0x3020250", Length = "0x94")]
		[NativeThrows]
		[Token(Token = "0x6000D37")]
		private static void ApplyToMeshesImpl(Mesh[] meshes, IntPtr* datas, int count, MeshUpdateFlags flags) { }

		[Address(RVA = "0x3020DE0", Offset = "0x30201E0", Length = "0x62")]
		[Token(Token = "0x6000D45")]
		private static void ApplyToMeshesImpl_Injected(Mesh[] meshes, IntPtr* datas, int count, MeshUpdateFlags flags) { }

		[Address(RVA = "0x3020AC0", Offset = "0x301FEC0", Length = "0xBA")]
		[NativeThrows]
		[Token(Token = "0x6000D38")]
		private static void ApplyToMeshImpl(Mesh mesh, IntPtr data, MeshUpdateFlags flags) { }

		[Address(RVA = "0x3020A60", Offset = "0x301FE60", Length = "0x52")]
		[Token(Token = "0x6000D46")]
		private static void ApplyToMeshImpl_Injected(IntPtr mesh, IntPtr data, MeshUpdateFlags flags) { }

		[Address(RVA = "0x3020EF0", Offset = "0x30202F0", Length = "0x40")]
		[Token(Token = "0x6000D36")]
		private static void CreateNewMeshDatas(IntPtr* datas, int count) { }

		[Address(RVA = "0x3020F30", Offset = "0x3020330", Length = "0x87")]
		[Token(Token = "0x6000D3B")]
		public override void Dispose() { }

		[Address(RVA = "0x30217D0", Offset = "0x3020BD0", Length = "0xD")]
		[Token(Token = "0x6000D3A")]
		public MeshData get_Item(int index) { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000D39")]
		public int get_Length() { }

		[Address(RVA = "0x3020FC0", Offset = "0x30203C0", Length = "0x40")]
		[Token(Token = "0x6000D35")]
		private static void ReleaseMeshDatas(IntPtr* datas, int count) { }

	}


	[Token(Token = "0x170001DB")]
	public int bindposeCount
	{
		[Address(RVA = "0x3034160", Offset = "0x3033560", Length = "0x76")]
		[Token(Token = "0x6000B81")]
		 get { } //Length: 118
	}

	[NativeName("BindPosesFromScript")]
	[Token(Token = "0x170001DC")]
	public Matrix4x4[] bindposes
	{
		[Address(RVA = "0x3034230", Offset = "0x3033630", Length = "0x12A")]
		[Token(Token = "0x6000B82")]
		 get { } //Length: 298
		[Address(RVA = "0x3035020", Offset = "0x3034420", Length = "0x104")]
		[Token(Token = "0x6000B83")]
		 set { } //Length: 260
	}

	[Token(Token = "0x170001DA")]
	public int blendShapeCount
	{
		[Address(RVA = "0x30343A0", Offset = "0x30337A0", Length = "0x76")]
		[NativeMethod(Name = "GetBlendShapeChannelCount")]
		[Token(Token = "0x6000B6C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170001F4")]
	public BoneWeight[] boneWeights
	{
		[Address(RVA = "0x3034420", Offset = "0x3033820", Length = "0x9")]
		[Token(Token = "0x6000C9A")]
		 get { } //Length: 9
		[Address(RVA = "0x302D840", Offset = "0x302CC40", Length = "0x104")]
		[Token(Token = "0x6000C9B")]
		 set { } //Length: 260
	}

	[Token(Token = "0x170001E1")]
	public Bounds bounds
	{
		[Address(RVA = "0x3034480", Offset = "0x3033880", Length = "0x94")]
		[Token(Token = "0x6000B9D")]
		 get { } //Length: 148
		[Address(RVA = "0x3035180", Offset = "0x3034580", Length = "0x85")]
		[Token(Token = "0x6000B9E")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170001DE")]
	internal bool canAccess
	{
		[Address(RVA = "0x3034560", Offset = "0x3033960", Length = "0x76")]
		[NativeMethod("CanAccessFromScript")]
		[Token(Token = "0x6000B8B")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x170001ED")]
	public Color[] colors
	{
		[Address(RVA = "0x3034630", Offset = "0x3033A30", Length = "0x3E")]
		[Token(Token = "0x6000BD0")]
		 get { } //Length: 62
		[Address(RVA = "0x3035280", Offset = "0x3034680", Length = "0x56")]
		[Token(Token = "0x6000BD1")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001EE")]
	public Color32[] colors32
	{
		[Address(RVA = "0x30345E0", Offset = "0x30339E0", Length = "0x50")]
		[Token(Token = "0x6000BD2")]
		 get { } //Length: 80
		[Address(RVA = "0x3035210", Offset = "0x3034610", Length = "0x69")]
		[Token(Token = "0x6000BD3")]
		 set { } //Length: 105
	}

	[Token(Token = "0x170001D9")]
	public Target indexBufferTarget
	{
		[Address(RVA = "0x30346B0", Offset = "0x3033AB0", Length = "0x76")]
		[Token(Token = "0x6000B6A")]
		 get { } //Length: 118
		[Address(RVA = "0x3035320", Offset = "0x3034720", Length = "0x83")]
		[Token(Token = "0x6000B6B")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001D6")]
	public IndexFormat indexFormat
	{
		[Address(RVA = "0x3034770", Offset = "0x3033B70", Length = "0x76")]
		[Token(Token = "0x6000B3B")]
		 get { } //Length: 118
		[Address(RVA = "0x30353F0", Offset = "0x30347F0", Length = "0x83")]
		[Token(Token = "0x6000B3C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001F0")]
	internal bool isLodSelectionActive
	{
		[Address(RVA = "0x30347F0", Offset = "0x3033BF0", Length = "0x7C")]
		[Token(Token = "0x6000BD6")]
		internal get { } //Length: 124
	}

	[Token(Token = "0x170001DD")]
	public bool isReadable
	{
		[Address(RVA = "0x30348B0", Offset = "0x3033CB0", Length = "0x76")]
		[NativeMethod("GetIsReadable")]
		[Token(Token = "0x6000B8A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170001EF")]
	public int lodCount
	{
		[Address(RVA = "0x3027F70", Offset = "0x3027370", Length = "0x76")]
		[Token(Token = "0x6000BD4")]
		 get { } //Length: 118
		[Address(RVA = "0x3035480", Offset = "0x3034880", Length = "0x218")]
		[Token(Token = "0x6000BD5")]
		 set { } //Length: 536
	}

	[Token(Token = "0x170001F1")]
	public LodSelectionCurve lodSelectionCurve
	{
		[Address(RVA = "0x3028040", Offset = "0x3027440", Length = "0x87")]
		[Token(Token = "0x6000BD7")]
		 get { } //Length: 135
		[Address(RVA = "0x30356A0", Offset = "0x3034AA0", Length = "0x80")]
		[Token(Token = "0x6000BD8")]
		 set { } //Length: 128
	}

	[Token(Token = "0x170001E3")]
	public Vector3[] normals
	{
		[Address(RVA = "0x3034930", Offset = "0x3033D30", Length = "0x3E")]
		[Token(Token = "0x6000BBC")]
		 get { } //Length: 62
		[Address(RVA = "0x3035730", Offset = "0x3034B30", Length = "0x56")]
		[Token(Token = "0x6000BBD")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001F5")]
	public SkinWeights skinWeightBufferLayout
	{
		[Address(RVA = "0x3025A20", Offset = "0x3024E20", Length = "0x76")]
		[Token(Token = "0x6000C9C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170001E0")]
	public int subMeshCount
	{
		[Address(RVA = "0x30349B0", Offset = "0x3033DB0", Length = "0x76")]
		[NativeMethod(Name = "GetSubMeshCount")]
		[Token(Token = "0x6000B8D")]
		 get { } //Length: 118
		[Address(RVA = "0x30357D0", Offset = "0x3034BD0", Length = "0x83")]
		[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
		[Token(Token = "0x6000B8E")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001E4")]
	public Vector4[] tangents
	{
		[Address(RVA = "0x3034A30", Offset = "0x3033E30", Length = "0x3E")]
		[Token(Token = "0x6000BBE")]
		 get { } //Length: 62
		[Address(RVA = "0x3035860", Offset = "0x3034C60", Length = "0x56")]
		[Token(Token = "0x6000BBF")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001F3")]
	public Int32[] triangles
	{
		[Address(RVA = "0x3034A70", Offset = "0x3033E70", Length = "0xD0")]
		[Token(Token = "0x6000C40")]
		 get { } //Length: 208
		[Address(RVA = "0x30358C0", Offset = "0x3034CC0", Length = "0x15F")]
		[Token(Token = "0x6000C41")]
		 set { } //Length: 351
	}

	[Token(Token = "0x170001E5")]
	public Vector2[] uv
	{
		[Address(RVA = "0x3034D10", Offset = "0x3034110", Length = "0x3E")]
		[Token(Token = "0x6000BC0")]
		 get { } //Length: 62
		[Address(RVA = "0x3035CC0", Offset = "0x30350C0", Length = "0x56")]
		[Token(Token = "0x6000BC1")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001E6")]
	public Vector2[] uv2
	{
		[Address(RVA = "0x3034B50", Offset = "0x3033F50", Length = "0x3E")]
		[Token(Token = "0x6000BC2")]
		 get { } //Length: 62
		[Address(RVA = "0x3035A20", Offset = "0x3034E20", Length = "0x56")]
		[Token(Token = "0x6000BC3")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001E7")]
	public Vector2[] uv3
	{
		[Address(RVA = "0x3034B90", Offset = "0x3033F90", Length = "0x3E")]
		[Token(Token = "0x6000BC4")]
		 get { } //Length: 62
		[Address(RVA = "0x3035A80", Offset = "0x3034E80", Length = "0x56")]
		[Token(Token = "0x6000BC5")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001E8")]
	public Vector2[] uv4
	{
		[Address(RVA = "0x3034BD0", Offset = "0x3033FD0", Length = "0x3E")]
		[Token(Token = "0x6000BC6")]
		 get { } //Length: 62
		[Address(RVA = "0x3035AE0", Offset = "0x3034EE0", Length = "0x56")]
		[Token(Token = "0x6000BC7")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001E9")]
	public Vector2[] uv5
	{
		[Address(RVA = "0x3034C10", Offset = "0x3034010", Length = "0x3E")]
		[Token(Token = "0x6000BC8")]
		 get { } //Length: 62
		[Address(RVA = "0x3035B40", Offset = "0x3034F40", Length = "0x56")]
		[Token(Token = "0x6000BC9")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001EA")]
	public Vector2[] uv6
	{
		[Address(RVA = "0x3034C50", Offset = "0x3034050", Length = "0x3E")]
		[Token(Token = "0x6000BCA")]
		 get { } //Length: 62
		[Address(RVA = "0x3035BA0", Offset = "0x3034FA0", Length = "0x56")]
		[Token(Token = "0x6000BCB")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001EB")]
	public Vector2[] uv7
	{
		[Address(RVA = "0x3034C90", Offset = "0x3034090", Length = "0x3E")]
		[Token(Token = "0x6000BCC")]
		 get { } //Length: 62
		[Address(RVA = "0x3035C00", Offset = "0x3035000", Length = "0x56")]
		[Token(Token = "0x6000BCD")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001EC")]
	public Vector2[] uv8
	{
		[Address(RVA = "0x3034CD0", Offset = "0x30340D0", Length = "0x3E")]
		[Token(Token = "0x6000BCE")]
		 get { } //Length: 62
		[Address(RVA = "0x3035C60", Offset = "0x3035060", Length = "0x56")]
		[Token(Token = "0x6000BCF")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170001F2")]
	public int vertexAttributeCount
	{
		[Address(RVA = "0x302A300", Offset = "0x3029700", Length = "0x76")]
		[Token(Token = "0x6000C23")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170001D7")]
	public int vertexBufferCount
	{
		[Address(RVA = "0x3034D90", Offset = "0x3034190", Length = "0x76")]
		[FreeFunction(Name = "MeshScripting::GetVertexBufferCount", HasExplicitThis = True)]
		[Token(Token = "0x6000B60")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170001D8")]
	public Target vertexBufferTarget
	{
		[Address(RVA = "0x3034E50", Offset = "0x3034250", Length = "0x76")]
		[Token(Token = "0x6000B68")]
		 get { } //Length: 118
		[Address(RVA = "0x3035D60", Offset = "0x3035160", Length = "0x83")]
		[Token(Token = "0x6000B69")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001DF")]
	public int vertexCount
	{
		[Address(RVA = "0x3034F10", Offset = "0x3034310", Length = "0x76")]
		[NativeMethod("GetVertexCount")]
		[Token(Token = "0x6000B8C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170001E2")]
	public Vector3[] vertices
	{
		[Address(RVA = "0x3034F90", Offset = "0x3034390", Length = "0x3B")]
		[Token(Token = "0x6000BBA")]
		 get { } //Length: 59
		[Address(RVA = "0x3035DF0", Offset = "0x30351F0", Length = "0x53")]
		[Token(Token = "0x6000BBB")]
		 set { } //Length: 83
	}

	[Address(RVA = "0x30340B0", Offset = "0x30334B0", Length = "0x6E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000B39")]
	public Mesh() { }

	[Address(RVA = "0x3022860", Offset = "0x3021C60", Length = "0x3E")]
	[Token(Token = "0x6000C2C")]
	public static MeshDataArray AcquireReadOnlyMeshData(Mesh mesh) { }

	[Address(RVA = "0x30228A0", Offset = "0x3021CA0", Length = "0xAD")]
	[Token(Token = "0x6000C2D")]
	public static MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes) { }

	[Address(RVA = "0x3022950", Offset = "0x3021D50", Length = "0x11D")]
	[Token(Token = "0x6000C2E")]
	public static MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes) { }

	[Address(RVA = "0x3022E60", Offset = "0x3022260", Length = "0x115")]
	[Token(Token = "0x6000B74")]
	public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[Address(RVA = "0x3022AE0", Offset = "0x3021EE0", Length = "0x375")]
	[FreeFunction(Name = "AddBlendShapeFrameFromScript", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B73")]
	public void AddBlendShapeFrame(string shapeName, float frameWeight, ReadOnlySpan<Vector3> deltaVertices, ReadOnlySpan<Vector3> deltaNormals, ReadOnlySpan<Vector3> deltaTangents) { }

	[Address(RVA = "0x3022A70", Offset = "0x3021E70", Length = "0x62")]
	[Token(Token = "0x6000CEA")]
	private static void AddBlendShapeFrame_Injected(IntPtr _unity_self, ref ManagedSpanWrapper shapeName, float frameWeight, ref ManagedSpanWrapper deltaVertices, ref ManagedSpanWrapper deltaNormals, ref ManagedSpanWrapper deltaTangents) { }

	[Address(RVA = "0x3022FC0", Offset = "0x30223C0", Length = "0x32")]
	[Token(Token = "0x6000C2F")]
	public static MeshDataArray AllocateWritableMeshData(int meshCount) { }

	[Address(RVA = "0x3022F80", Offset = "0x3022380", Length = "0x3F")]
	[Token(Token = "0x6000C30")]
	public static MeshDataArray AllocateWritableMeshData(Mesh mesh) { }

	[Address(RVA = "0x3023120", Offset = "0x3022520", Length = "0xAD")]
	[Token(Token = "0x6000C31")]
	public static MeshDataArray AllocateWritableMeshData(Mesh[] meshes) { }

	[Address(RVA = "0x3023000", Offset = "0x3022400", Length = "0x11D")]
	[Token(Token = "0x6000C32")]
	public static MeshDataArray AllocateWritableMeshData(List<Mesh> meshes) { }

	[Address(RVA = "0x3023500", Offset = "0x3022900", Length = "0x166")]
	[Token(Token = "0x6000C33")]
	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh mesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x30231D0", Offset = "0x30225D0", Length = "0x1DA")]
	[Token(Token = "0x6000C35")]
	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, List<Mesh> meshes, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x30233B0", Offset = "0x30227B0", Length = "0x148")]
	[Token(Token = "0x6000C34")]
	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh[] meshes, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x3023690", Offset = "0x3022A90", Length = "0x190")]
	[Token(Token = "0x6000C3D")]
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	[Address(RVA = "0x3023670", Offset = "0x3022A70", Length = "0xD")]
	[Token(Token = "0x6000C3F")]
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	[Address(RVA = "0x3023680", Offset = "0x3022A80", Length = "0xD")]
	[Token(Token = "0x6000C3E")]
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	[Address(RVA = "0x3023830", Offset = "0x3022C30", Length = "0x244")]
	[Token(Token = "0x6000C5A")]
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	[Address(RVA = "0x3023C20", Offset = "0x3023020", Length = "0x78")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C9E")]
	public void Clear() { }

	[Address(RVA = "0x3023B90", Offset = "0x3022F90", Length = "0x86")]
	[Token(Token = "0x6000C9D")]
	public void Clear(bool keepVertexLayout) { }

	[Address(RVA = "0x3023AC0", Offset = "0x3022EC0", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::ClearBlendShapes", HasExplicitThis = True)]
	[Token(Token = "0x6000B6D")]
	public void ClearBlendShapes() { }

	[Address(RVA = "0x3023A80", Offset = "0x3022E80", Length = "0x33")]
	[Token(Token = "0x6000CE4")]
	private static void ClearBlendShapes_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3023B90", Offset = "0x3022F90", Length = "0x86")]
	[NativeMethod("Clear")]
	[Token(Token = "0x6000B9F")]
	private void ClearImpl(bool keepVertexLayout) { }

	[Address(RVA = "0x3023B40", Offset = "0x3022F40", Length = "0x42")]
	[Token(Token = "0x6000D10")]
	private static void ClearImpl_Injected(IntPtr _unity_self, bool keepVertexLayout) { }

	[Address(RVA = "0x3023E90", Offset = "0x3023290", Length = "0x17")]
	[Token(Token = "0x6000CAD")]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[Address(RVA = "0x3023EB0", Offset = "0x30232B0", Length = "0x1C")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000CAE")]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[Address(RVA = "0x3023E60", Offset = "0x3023260", Length = "0x23")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000CB0")]
	public void CombineMeshes(CombineInstance[] combine) { }

	[Address(RVA = "0x3023ED0", Offset = "0x30232D0", Length = "0x1F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000CAF")]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	[Address(RVA = "0x3023D20", Offset = "0x3023120", Length = "0x136")]
	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
	[Token(Token = "0x6000BAA")]
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[Address(RVA = "0x3023CA0", Offset = "0x30230A0", Length = "0x71")]
	[Token(Token = "0x6000D1B")]
	private static void CombineMeshesImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[Address(RVA = "0x3023EF0", Offset = "0x30232F0", Length = "0xAD")]
	[Token(Token = "0x6000BAF")]
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	[Address(RVA = "0x3023FE0", Offset = "0x30233E0", Length = "0x5E")]
	[FreeFunction("MeshScripting::MeshFromInstanceId")]
	[Token(Token = "0x6000B3A")]
	internal static Mesh FromInstanceID(EntityId id) { }

	[Address(RVA = "0x3023FA0", Offset = "0x30233A0", Length = "0x33")]
	[Token(Token = "0x6000CB1")]
	private static IntPtr FromInstanceID_Injected(in EntityId id) { }

	[Address(RVA = "0x3034160", Offset = "0x3033560", Length = "0x76")]
	[Token(Token = "0x6000B81")]
	public int get_bindposeCount() { }

	[Address(RVA = "0x3034120", Offset = "0x3033520", Length = "0x33")]
	[Token(Token = "0x6000CF4")]
	private static int get_bindposeCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3034230", Offset = "0x3033630", Length = "0x12A")]
	[Token(Token = "0x6000B82")]
	public Matrix4x4[] get_bindposes() { }

	[Address(RVA = "0x30341E0", Offset = "0x30335E0", Length = "0x42")]
	[Token(Token = "0x6000CF5")]
	private static void get_bindposes_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x30343A0", Offset = "0x30337A0", Length = "0x76")]
	[NativeMethod(Name = "GetBlendShapeChannelCount")]
	[Token(Token = "0x6000B6C")]
	public int get_blendShapeCount() { }

	[Address(RVA = "0x3034360", Offset = "0x3033760", Length = "0x33")]
	[Token(Token = "0x6000CE3")]
	private static int get_blendShapeCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3034420", Offset = "0x3033820", Length = "0x9")]
	[Token(Token = "0x6000C9A")]
	public BoneWeight[] get_boneWeights() { }

	[Address(RVA = "0x3034480", Offset = "0x3033880", Length = "0x94")]
	[Token(Token = "0x6000B9D")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x3034430", Offset = "0x3033830", Length = "0x42")]
	[Token(Token = "0x6000D0E")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x3034560", Offset = "0x3033960", Length = "0x76")]
	[NativeMethod("CanAccessFromScript")]
	[Token(Token = "0x6000B8B")]
	internal bool get_canAccess() { }

	[Address(RVA = "0x3034520", Offset = "0x3033920", Length = "0x33")]
	[Token(Token = "0x6000CFC")]
	private static bool get_canAccess_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3034630", Offset = "0x3033A30", Length = "0x3E")]
	[Token(Token = "0x6000BD0")]
	public Color[] get_colors() { }

	[Address(RVA = "0x30345E0", Offset = "0x30339E0", Length = "0x50")]
	[Token(Token = "0x6000BD2")]
	public Color32[] get_colors32() { }

	[Address(RVA = "0x30346B0", Offset = "0x3033AB0", Length = "0x76")]
	[Token(Token = "0x6000B6A")]
	public Target get_indexBufferTarget() { }

	[Address(RVA = "0x3034670", Offset = "0x3033A70", Length = "0x33")]
	[Token(Token = "0x6000CE1")]
	private static Target get_indexBufferTarget_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3034770", Offset = "0x3033B70", Length = "0x76")]
	[Token(Token = "0x6000B3B")]
	public IndexFormat get_indexFormat() { }

	[Address(RVA = "0x3034730", Offset = "0x3033B30", Length = "0x33")]
	[Token(Token = "0x6000CB2")]
	private static IndexFormat get_indexFormat_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30347F0", Offset = "0x3033BF0", Length = "0x7C")]
	[Token(Token = "0x6000BD6")]
	internal bool get_isLodSelectionActive() { }

	[Address(RVA = "0x30348B0", Offset = "0x3033CB0", Length = "0x76")]
	[NativeMethod("GetIsReadable")]
	[Token(Token = "0x6000B8A")]
	public bool get_isReadable() { }

	[Address(RVA = "0x3034870", Offset = "0x3033C70", Length = "0x33")]
	[Token(Token = "0x6000CFB")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3027F70", Offset = "0x3027370", Length = "0x76")]
	[Token(Token = "0x6000BD4")]
	public int get_lodCount() { }

	[Address(RVA = "0x3028040", Offset = "0x3027440", Length = "0x87")]
	[Token(Token = "0x6000BD7")]
	public LodSelectionCurve get_lodSelectionCurve() { }

	[Address(RVA = "0x3034930", Offset = "0x3033D30", Length = "0x3E")]
	[Token(Token = "0x6000BBC")]
	public Vector3[] get_normals() { }

	[Address(RVA = "0x3025A20", Offset = "0x3024E20", Length = "0x76")]
	[Token(Token = "0x6000C9C")]
	public SkinWeights get_skinWeightBufferLayout() { }

	[Address(RVA = "0x30349B0", Offset = "0x3033DB0", Length = "0x76")]
	[NativeMethod(Name = "GetSubMeshCount")]
	[Token(Token = "0x6000B8D")]
	public int get_subMeshCount() { }

	[Address(RVA = "0x3034970", Offset = "0x3033D70", Length = "0x33")]
	[Token(Token = "0x6000CFE")]
	private static int get_subMeshCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3034A30", Offset = "0x3033E30", Length = "0x3E")]
	[Token(Token = "0x6000BBE")]
	public Vector4[] get_tangents() { }

	[Address(RVA = "0x3034A70", Offset = "0x3033E70", Length = "0xD0")]
	[Token(Token = "0x6000C40")]
	public Int32[] get_triangles() { }

	[Address(RVA = "0x3034D10", Offset = "0x3034110", Length = "0x3E")]
	[Token(Token = "0x6000BC0")]
	public Vector2[] get_uv() { }

	[Address(RVA = "0x3034B50", Offset = "0x3033F50", Length = "0x3E")]
	[Token(Token = "0x6000BC2")]
	public Vector2[] get_uv2() { }

	[Address(RVA = "0x3034B90", Offset = "0x3033F90", Length = "0x3E")]
	[Token(Token = "0x6000BC4")]
	public Vector2[] get_uv3() { }

	[Address(RVA = "0x3034BD0", Offset = "0x3033FD0", Length = "0x3E")]
	[Token(Token = "0x6000BC6")]
	public Vector2[] get_uv4() { }

	[Address(RVA = "0x3034C10", Offset = "0x3034010", Length = "0x3E")]
	[Token(Token = "0x6000BC8")]
	public Vector2[] get_uv5() { }

	[Address(RVA = "0x3034C50", Offset = "0x3034050", Length = "0x3E")]
	[Token(Token = "0x6000BCA")]
	public Vector2[] get_uv6() { }

	[Address(RVA = "0x3034C90", Offset = "0x3034090", Length = "0x3E")]
	[Token(Token = "0x6000BCC")]
	public Vector2[] get_uv7() { }

	[Address(RVA = "0x3034CD0", Offset = "0x30340D0", Length = "0x3E")]
	[Token(Token = "0x6000BCE")]
	public Vector2[] get_uv8() { }

	[Address(RVA = "0x302A300", Offset = "0x3029700", Length = "0x76")]
	[Token(Token = "0x6000C23")]
	public int get_vertexAttributeCount() { }

	[Address(RVA = "0x3034D90", Offset = "0x3034190", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::GetVertexBufferCount", HasExplicitThis = True)]
	[Token(Token = "0x6000B60")]
	public int get_vertexBufferCount() { }

	[Address(RVA = "0x3034D50", Offset = "0x3034150", Length = "0x33")]
	[Token(Token = "0x6000CD7")]
	private static int get_vertexBufferCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3034E50", Offset = "0x3034250", Length = "0x76")]
	[Token(Token = "0x6000B68")]
	public Target get_vertexBufferTarget() { }

	[Address(RVA = "0x3034E10", Offset = "0x3034210", Length = "0x33")]
	[Token(Token = "0x6000CDF")]
	private static Target get_vertexBufferTarget_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3034F10", Offset = "0x3034310", Length = "0x76")]
	[NativeMethod("GetVertexCount")]
	[Token(Token = "0x6000B8C")]
	public int get_vertexCount() { }

	[Address(RVA = "0x3034ED0", Offset = "0x30342D0", Length = "0x33")]
	[Token(Token = "0x6000CFD")]
	private static int get_vertexCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3034F90", Offset = "0x3034390", Length = "0x3B")]
	[Token(Token = "0x6000BBA")]
	public Vector3[] get_vertices() { }

	[Address(RVA = "0x30241C0", Offset = "0x30235C0", Length = "0x13F")]
	[Token(Token = "0x6000B7B")]
	public NativeArray<BoneWeight1> GetAllBoneWeights() { }

	[Address(RVA = "0x3024140", Offset = "0x3023540", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::GetAllBoneWeightsArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B7F")]
	private IntPtr GetAllBoneWeightsArray() { }

	[Address(RVA = "0x3024100", Offset = "0x3023500", Length = "0x33")]
	[Token(Token = "0x6000CF2")]
	private static IntPtr GetAllBoneWeightsArray_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3024080", Offset = "0x3023480", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::GetAllBoneWeightsArraySize", HasExplicitThis = True)]
	[Token(Token = "0x6000B7D")]
	private int GetAllBoneWeightsArraySize() { }

	[Address(RVA = "0x3024040", Offset = "0x3023440", Length = "0x33")]
	[Token(Token = "0x6000CF0")]
	private static int GetAllBoneWeightsArraySize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x884150", Offset = "0x883550", Length = "0x117")]
	[Token(Token = "0x6000BB1")]
	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	[Address(RVA = "0x884050", Offset = "0x883450", Length = "0xF9")]
	[Token(Token = "0x6000BB0")]
	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[Address(RVA = "0x3024360", Offset = "0x3023760", Length = "0xA7")]
	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000B5E")]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[Address(RVA = "0x3024300", Offset = "0x3023700", Length = "0x60")]
	[Token(Token = "0x6000CD5")]
	private static Array GetAllocArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[Address(RVA = "0x3024470", Offset = "0x3023870", Length = "0xA7")]
	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000B5F")]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[Address(RVA = "0x3024410", Offset = "0x3023810", Length = "0x60")]
	[Token(Token = "0x6000CD6")]
	private static void GetArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[Address(RVA = "0x30245F0", Offset = "0x30239F0", Length = "0x12F")]
	[Token(Token = "0x6000C59")]
	public uint GetBaseVertex(int submesh) { }

	[Address(RVA = "0x3024560", Offset = "0x3023960", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetBaseVertex", HasExplicitThis = True)]
	[Token(Token = "0x6000B4D")]
	private uint GetBaseVertexImpl(int submesh) { }

	[Address(RVA = "0x3024520", Offset = "0x3023920", Length = "0x40")]
	[Token(Token = "0x6000CC4")]
	private static uint GetBaseVertexImpl_Injected(IntPtr _unity_self, int submesh) { }

	[Address(RVA = "0x3024970", Offset = "0x3023D70", Length = "0x13F")]
	[Token(Token = "0x6000B84")]
	public NativeArray<Matrix4x4> GetBindposes() { }

	[Address(RVA = "0x3024AB0", Offset = "0x3023EB0", Length = "0x15C")]
	[Token(Token = "0x6000C98")]
	public void GetBindposes(List<Matrix4x4> bindposes) { }

	[Address(RVA = "0x3024760", Offset = "0x3023B60", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::GetBindposesArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B87")]
	private IntPtr GetBindposesArray() { }

	[Address(RVA = "0x3024720", Offset = "0x3023B20", Length = "0x33")]
	[Token(Token = "0x6000CF8")]
	private static IntPtr GetBindposesArray_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3024830", Offset = "0x3023C30", Length = "0x13C")]
	[FreeFunction(Name = "MeshScripting::ExtractBindPosesIntoArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B89")]
	private void GetBindposesNonAllocImpl(out Matrix4x4[] values) { }

	[Address(RVA = "0x30247E0", Offset = "0x3023BE0", Length = "0x42")]
	[Token(Token = "0x6000CFA")]
	private static void GetBindposesNonAllocImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper values) { }

	[Address(RVA = "0x3024F80", Offset = "0x3024380", Length = "0xE3")]
	[Token(Token = "0x6000C3A")]
	public GraphicsBuffer GetBlendShapeBuffer() { }

	[Address(RVA = "0x3024E80", Offset = "0x3024280", Length = "0xF3")]
	[Token(Token = "0x6000C39")]
	public GraphicsBuffer GetBlendShapeBuffer(BlendShapeBufferLayout layout) { }

	[Address(RVA = "0x3024C50", Offset = "0x3024050", Length = "0xA6")]
	[FreeFunction(Name = "MeshScripting::GetBlendShapeBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B67")]
	private GraphicsBuffer GetBlendShapeBufferImpl(int layout) { }

	[Address(RVA = "0x3024C10", Offset = "0x3024010", Length = "0x40")]
	[Token(Token = "0x6000CDE")]
	private static IntPtr GetBlendShapeBufferImpl_Injected(IntPtr _unity_self, int layout) { }

	[Address(RVA = "0x3024D00", Offset = "0x3024100", Length = "0x177")]
	[Token(Token = "0x6000C3B")]
	public BlendShapeBufferRange GetBlendShapeBufferRange(int blendShapeIndex) { }

	[Address(RVA = "0x30250B0", Offset = "0x30244B0", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameCount", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B70")]
	public int GetBlendShapeFrameCount(int shapeIndex) { }

	[Address(RVA = "0x3025070", Offset = "0x3024470", Length = "0x40")]
	[Token(Token = "0x6000CE7")]
	private static int GetBlendShapeFrameCount_Injected(IntPtr _unity_self, int shapeIndex) { }

	[Address(RVA = "0x30251A0", Offset = "0x30245A0", Length = "0x1D4")]
	[FreeFunction(Name = "GetBlendShapeFrameVerticesFromScript", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B72")]
	public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[Address(RVA = "0x3025140", Offset = "0x3024540", Length = "0x60")]
	[Token(Token = "0x6000CE9")]
	private static void GetBlendShapeFrameVertices_Injected(IntPtr _unity_self, int shapeIndex, int frameIndex, ref ManagedSpanWrapper deltaVertices, ref ManagedSpanWrapper deltaNormals, ref ManagedSpanWrapper deltaTangents) { }

	[Address(RVA = "0x30253D0", Offset = "0x30247D0", Length = "0x93")]
	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameWeight", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B71")]
	public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) { }

	[Address(RVA = "0x3025380", Offset = "0x3024780", Length = "0x50")]
	[Token(Token = "0x6000CE8")]
	private static float GetBlendShapeFrameWeight_Injected(IntPtr _unity_self, int shapeIndex, int frameIndex) { }

	[Address(RVA = "0x30254C0", Offset = "0x30248C0", Length = "0x1CD")]
	[FreeFunction(Name = "MeshScripting::GetBlendShapeIndex", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B6F")]
	public int GetBlendShapeIndex(string blendShapeName) { }

	[Address(RVA = "0x3025470", Offset = "0x3024870", Length = "0x42")]
	[Token(Token = "0x6000CE6")]
	private static int GetBlendShapeIndex_Injected(IntPtr _unity_self, ref ManagedSpanWrapper blendShapeName) { }

	[Address(RVA = "0x30256E0", Offset = "0x3024AE0", Length = "0x113")]
	[FreeFunction(Name = "MeshScripting::GetBlendShapeName", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B6E")]
	public string GetBlendShapeName(int shapeIndex) { }

	[Address(RVA = "0x3025690", Offset = "0x3024A90", Length = "0x50")]
	[Token(Token = "0x6000CE5")]
	private static void GetBlendShapeName_Injected(IntPtr _unity_self, int shapeIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3025850", Offset = "0x3024C50", Length = "0x9F")]
	[FreeFunction(Name = "MeshScripting::GetBlendShapeOffset", HasExplicitThis = True)]
	[Token(Token = "0x6000B75")]
	private BlendShape GetBlendShapeOffsetInternal(int index) { }

	[Address(RVA = "0x3025800", Offset = "0x3024C00", Length = "0x50")]
	[Token(Token = "0x6000CEB")]
	private static void GetBlendShapeOffsetInternal_Injected(IntPtr _unity_self, int index, out BlendShape ret) { }

	[Address(RVA = "0x3026390", Offset = "0x3025790", Length = "0x19B")]
	[Token(Token = "0x6000B7C")]
	public NativeArray<Byte> GetBonesPerVertex() { }

	[Address(RVA = "0x3026310", Offset = "0x3025710", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::GetBonesPerVertexArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B80")]
	private IntPtr GetBonesPerVertexArray() { }

	[Address(RVA = "0x30262D0", Offset = "0x30256D0", Length = "0x33")]
	[Token(Token = "0x6000CF3")]
	private static IntPtr GetBonesPerVertexArray_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3025AA0", Offset = "0x3024EA0", Length = "0x35C")]
	[Token(Token = "0x6000C38")]
	public GraphicsBuffer GetBoneWeightBuffer(SkinWeights layout) { }

	[Address(RVA = "0x3025930", Offset = "0x3024D30", Length = "0xA6")]
	[FreeFunction(Name = "MeshScripting::GetBoneWeightBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B66")]
	private GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex) { }

	[Address(RVA = "0x30258F0", Offset = "0x3024CF0", Length = "0x40")]
	[Token(Token = "0x6000CDD")]
	private static IntPtr GetBoneWeightBufferImpl_Injected(IntPtr _unity_self, int bonesPerVertex) { }

	[Address(RVA = "0x3025A20", Offset = "0x3024E20", Length = "0x76")]
	[NativeMethod("GetBoneWeightBufferDimension")]
	[Token(Token = "0x6000B7E")]
	private int GetBoneWeightBufferLayoutInternal() { }

	[Address(RVA = "0x30259E0", Offset = "0x3024DE0", Length = "0x33")]
	[Token(Token = "0x6000CF1")]
	private static int GetBoneWeightBufferLayoutInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3026110", Offset = "0x3025510", Length = "0x1B3")]
	[Token(Token = "0x6000C99")]
	public void GetBoneWeights(List<BoneWeight> boneWeights) { }

	[Address(RVA = "0x3025E50", Offset = "0x3025250", Length = "0x12A")]
	[FreeFunction(Name = "MeshScripting::GetBoneWeights", HasExplicitThis = True)]
	[Token(Token = "0x6000B77")]
	private BoneWeight[] GetBoneWeightsImpl() { }

	[Address(RVA = "0x3025E00", Offset = "0x3025200", Length = "0x42")]
	[Token(Token = "0x6000CED")]
	private static void GetBoneWeightsImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3025FD0", Offset = "0x30253D0", Length = "0x13C")]
	[FreeFunction(Name = "MeshScripting::ExtractBoneWeightsIntoArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B88")]
	private void GetBoneWeightsNonAllocImpl(out BoneWeight[] values) { }

	[Address(RVA = "0x3025F80", Offset = "0x3025380", Length = "0x42")]
	[Token(Token = "0x6000CF9")]
	private static void GetBoneWeightsNonAllocImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper values) { }

	[Address(RVA = "0x3026660", Offset = "0x3025A60", Length = "0x136")]
	[Token(Token = "0x6000BFE")]
	public void GetColors(List<Color32> colors) { }

	[Address(RVA = "0x3026530", Offset = "0x3025930", Length = "0x12E")]
	[Token(Token = "0x6000BF7")]
	public void GetColors(List<Color> colors) { }

	[Address(RVA = "0x3026880", Offset = "0x3025C80", Length = "0x11B")]
	[Token(Token = "0x6000C37")]
	public GraphicsBuffer GetIndexBuffer() { }

	[Address(RVA = "0x30267E0", Offset = "0x3025BE0", Length = "0x99")]
	[FreeFunction(Name = "MeshScripting::GetIndexBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B65")]
	private GraphicsBuffer GetIndexBufferImpl() { }

	[Address(RVA = "0x30267A0", Offset = "0x3025BA0", Length = "0x33")]
	[Token(Token = "0x6000CDC")]
	private static IntPtr GetIndexBufferImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3026BD0", Offset = "0x3025FD0", Length = "0x235")]
	[Token(Token = "0x6000C58")]
	public uint GetIndexCount(int submesh, int meshLod) { }

	[Address(RVA = "0x3026A90", Offset = "0x3025E90", Length = "0x132")]
	[Token(Token = "0x6000C57")]
	public uint GetIndexCount(int submesh) { }

	[Address(RVA = "0x30269F0", Offset = "0x3025DF0", Length = "0x93")]
	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	[Token(Token = "0x6000B4B")]
	private uint GetIndexCountImpl(int submesh, int meshlod) { }

	[Address(RVA = "0x30269A0", Offset = "0x3025DA0", Length = "0x50")]
	[Token(Token = "0x6000CC2")]
	private static uint GetIndexCountImpl_Injected(IntPtr _unity_self, int submesh, int meshlod) { }

	[Address(RVA = "0x3026F00", Offset = "0x3026300", Length = "0x132")]
	[Token(Token = "0x6000C55")]
	public uint GetIndexStart(int submesh) { }

	[Address(RVA = "0x3027040", Offset = "0x3026440", Length = "0x235")]
	[Token(Token = "0x6000C56")]
	public uint GetIndexStart(int submesh, int meshLod) { }

	[Address(RVA = "0x3026E60", Offset = "0x3026260", Length = "0x93")]
	[FreeFunction(Name = "MeshScripting::GetIndexStart", HasExplicitThis = True)]
	[Token(Token = "0x6000B4A")]
	private uint GetIndexStartImpl(int submesh, int meshlod) { }

	[Address(RVA = "0x3026E10", Offset = "0x3026210", Length = "0x50")]
	[Token(Token = "0x6000CC1")]
	private static uint GetIndexStartImpl_Injected(IntPtr _unity_self, int submesh, int meshlod) { }

	[Address(RVA = "0x3027B40", Offset = "0x3026F40", Length = "0x1F9")]
	[Token(Token = "0x6000C51")]
	public void GetIndices(List<UInt16> indices, int submesh, int meshLod, bool applyBaseVertex = true) { }

	[Address(RVA = "0x3027810", Offset = "0x3026C10", Length = "0x1D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C4A")]
	public Int32[] GetIndices(int submesh) { }

	[Address(RVA = "0x3027D60", Offset = "0x3027160", Length = "0x187")]
	[Token(Token = "0x6000C4C")]
	public Int32[] GetIndices(int submesh, int meshLod, bool applyBaseVertex = true) { }

	[Address(RVA = "0x3027B20", Offset = "0x3026F20", Length = "0x1F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C4D")]
	public void GetIndices(List<Int32> indices, int submesh) { }

	[Address(RVA = "0x3027D40", Offset = "0x3027140", Length = "0x1F")]
	[Token(Token = "0x6000C4E")]
	public void GetIndices(List<Int32> indices, int submesh, bool applyBaseVertex) { }

	[Address(RVA = "0x3027830", Offset = "0x3026C30", Length = "0x2E6")]
	[Token(Token = "0x6000C4F")]
	public void GetIndices(List<Int32> indices, int submesh, int meshLod, bool applyBaseVertex = false) { }

	[Address(RVA = "0x3027EF0", Offset = "0x30272F0", Length = "0x1F")]
	[Token(Token = "0x6000C50")]
	public void GetIndices(List<UInt16> indices, int submesh, bool applyBaseVertex = true) { }

	[Address(RVA = "0x3027F10", Offset = "0x3027310", Length = "0x1E")]
	[Token(Token = "0x6000C4B")]
	public Int32[] GetIndices(int submesh, bool applyBaseVertex) { }

	[Address(RVA = "0x30272F0", Offset = "0x30266F0", Length = "0x15D")]
	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	[Token(Token = "0x6000B4F")]
	private Int32[] GetIndicesImpl(int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x3027280", Offset = "0x3026680", Length = "0x62")]
	[Token(Token = "0x6000CC6")]
	private static void GetIndicesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, int meshlod, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x30276A0", Offset = "0x3026AA0", Length = "0x16E")]
	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B54")]
	private void GetIndicesNonAllocImpl(out Int32[] values, int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x3027630", Offset = "0x3026A30", Length = "0x64")]
	[Token(Token = "0x6000CCB")]
	private static void GetIndicesNonAllocImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper values, int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x30274C0", Offset = "0x30268C0", Length = "0x16E")]
	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray16", HasExplicitThis = True)]
	[Token(Token = "0x6000B55")]
	private void GetIndicesNonAllocImpl16(out UInt16[] values, int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x3027450", Offset = "0x3026850", Length = "0x64")]
	[Token(Token = "0x6000CCC")]
	private static void GetIndicesNonAllocImpl16_Injected(IntPtr _unity_self, out BlittableArrayWrapper values, int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x8842D0", Offset = "0x8836D0", Length = "0xFC")]
	[Token(Token = "0x6000BB9")]
	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	[Address(RVA = "0x8843D0", Offset = "0x8837D0", Length = "0x111")]
	[Token(Token = "0x6000BB8")]
	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	[Address(RVA = "0x3028130", Offset = "0x3027530", Length = "0xA6")]
	[FreeFunction("MeshScripting::GetLod", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B9C")]
	public MeshLodRange GetLod(int subMeshIndex, int levelIndex) { }

	[Address(RVA = "0x30280D0", Offset = "0x30274D0", Length = "0x60")]
	[Token(Token = "0x6000D0D")]
	private static void GetLod_Injected(IntPtr _unity_self, int subMeshIndex, int levelIndex, out MeshLodRange ret) { }

	[Address(RVA = "0x3027F70", Offset = "0x3027370", Length = "0x76")]
	[FreeFunction("MeshScripting::GetLodCount", HasExplicitThis = True)]
	[Token(Token = "0x6000B9A")]
	private int GetLodCount() { }

	[Address(RVA = "0x3027F30", Offset = "0x3027330", Length = "0x33")]
	[Token(Token = "0x6000D0B")]
	private static int GetLodCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3028550", Offset = "0x3027950", Length = "0x17D")]
	[Token(Token = "0x6000C97")]
	public void GetLods(List<MeshLodRange> levels, int submesh) { }

	[Address(RVA = "0x3028520", Offset = "0x3027920", Length = "0x2E")]
	[Token(Token = "0x6000C96")]
	public MeshLodRange[] GetLods(int submesh) { }

	[Address(RVA = "0x3028230", Offset = "0x3027630", Length = "0x13B")]
	[FreeFunction("MeshScripting::GetLods", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B98")]
	private MeshLodRange[] GetLodsAlloc(int subMeshIndex) { }

	[Address(RVA = "0x30281E0", Offset = "0x30275E0", Length = "0x50")]
	[Token(Token = "0x6000D09")]
	private static void GetLodsAlloc_Injected(IntPtr _unity_self, int subMeshIndex, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3028040", Offset = "0x3027440", Length = "0x87")]
	[FreeFunction("MeshScripting::GetLodSelectionCurve", HasExplicitThis = True)]
	[Token(Token = "0x6000B9B")]
	private LodSelectionCurve GetLodSelectionCurve() { }

	[Address(RVA = "0x3027FF0", Offset = "0x30273F0", Length = "0x42")]
	[Token(Token = "0x6000D0C")]
	private static void GetLodSelectionCurve_Injected(IntPtr _unity_self, out LodSelectionCurve ret) { }

	[Address(RVA = "0x30283D0", Offset = "0x30277D0", Length = "0x14E")]
	[FreeFunction(Name = "MeshScripting::GetLodsNonAlloc", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B99")]
	private void GetLodsNonAlloc(out MeshLodRange[] levels, int subMeshIndex) { }

	[Address(RVA = "0x3028370", Offset = "0x3027770", Length = "0x52")]
	[Token(Token = "0x6000D0A")]
	private static void GetLodsNonAlloc_Injected(IntPtr _unity_self, out BlittableArrayWrapper levels, int subMeshIndex) { }

	[Address(RVA = "0x3028710", Offset = "0x3027B10", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::GetNativeIndexBufferPtr", HasExplicitThis = True)]
	[Token(Token = "0x6000B63")]
	public IntPtr GetNativeIndexBufferPtr() { }

	[Address(RVA = "0x30286D0", Offset = "0x3027AD0", Length = "0x33")]
	[Token(Token = "0x6000CDA")]
	private static IntPtr GetNativeIndexBufferPtr_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30287D0", Offset = "0x3027BD0", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetNativeVertexBufferPtr", HasExplicitThis = True)]
	[NativeThrows]
	[Token(Token = "0x6000B62")]
	public IntPtr GetNativeVertexBufferPtr(int index) { }

	[Address(RVA = "0x3028790", Offset = "0x3027B90", Length = "0x40")]
	[Token(Token = "0x6000CD9")]
	private static IntPtr GetNativeVertexBufferPtr_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x3028860", Offset = "0x3027C60", Length = "0x12E")]
	[Token(Token = "0x6000BE3")]
	public void GetNormals(List<Vector3> normals) { }

	[Address(RVA = "0x30289E0", Offset = "0x3027DE0", Length = "0xA5")]
	[FreeFunction("MeshScripting::GetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B90")]
	public SubMeshDescriptor GetSubMesh(int index) { }

	[Address(RVA = "0x3028990", Offset = "0x3027D90", Length = "0x50")]
	[Token(Token = "0x6000D01")]
	private static void GetSubMesh_Injected(IntPtr _unity_self, int index, out SubMeshDescriptor ret) { }

	[Address(RVA = "0x3028A90", Offset = "0x3027E90", Length = "0x12E")]
	[Token(Token = "0x6000BED")]
	public void GetTangents(List<Vector4> tangents) { }

	[Address(RVA = "0x3028C90", Offset = "0x3028090", Length = "0x14C")]
	[Token(Token = "0x6000CAC")]
	public MeshTopology GetTopology(int submesh) { }

	[Address(RVA = "0x3028C00", Offset = "0x3028000", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = True)]
	[Token(Token = "0x6000BA6")]
	private MeshTopology GetTopologyImpl(int submesh) { }

	[Address(RVA = "0x3028BC0", Offset = "0x3027FC0", Length = "0x40")]
	[Token(Token = "0x6000D17")]
	private static MeshTopology GetTopologyImpl_Injected(IntPtr _unity_self, int submesh) { }

	[Address(RVA = "0x3028E20", Offset = "0x3028220", Length = "0x76")]
	[Token(Token = "0x6000B3D")]
	internal uint GetTotalIndexCount() { }

	[Address(RVA = "0x3028DE0", Offset = "0x30281E0", Length = "0x33")]
	[Token(Token = "0x6000CB4")]
	private static uint GetTotalIndexCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3029B50", Offset = "0x3028F50", Length = "0x1F")]
	[Token(Token = "0x6000C46")]
	public void GetTriangles(List<Int32> triangles, int submesh, bool applyBaseVertex) { }

	[Address(RVA = "0x3029B70", Offset = "0x3028F70", Length = "0x1F")]
	[Token(Token = "0x6000C45")]
	public void GetTriangles(List<Int32> triangles, int submesh) { }

	[Address(RVA = "0x30296D0", Offset = "0x3028AD0", Length = "0x187")]
	[Token(Token = "0x6000C44")]
	public Int32[] GetTriangles(int submesh, int meshLod, bool applyBaseVertex) { }

	[Address(RVA = "0x3029E80", Offset = "0x3029280", Length = "0x18C")]
	[Token(Token = "0x6000C43")]
	public Int32[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[Address(RVA = "0x3029860", Offset = "0x3028C60", Length = "0x2E7")]
	[Token(Token = "0x6000C47")]
	public void GetTriangles(List<Int32> triangles, int submesh, int meshLod, bool applyBaseVertex = true) { }

	[Address(RVA = "0x3029520", Offset = "0x3028920", Length = "0x1F")]
	[Token(Token = "0x6000C48")]
	public void GetTriangles(List<UInt16> triangles, int submesh, bool applyBaseVertex = true) { }

	[Address(RVA = "0x3029540", Offset = "0x3028940", Length = "0x18F")]
	[Token(Token = "0x6000C42")]
	public Int32[] GetTriangles(int submesh) { }

	[Address(RVA = "0x3029B90", Offset = "0x3028F90", Length = "0x2E7")]
	[Token(Token = "0x6000C49")]
	public void GetTriangles(List<UInt16> triangles, int submesh, int meshLod, bool applyBaseVertex = true) { }

	[Address(RVA = "0x3028EF0", Offset = "0x30282F0", Length = "0x93")]
	[FreeFunction(Name = "MeshScripting::GetTrianglesCount", HasExplicitThis = True)]
	[Token(Token = "0x6000B4C")]
	private uint GetTrianglesCountImpl(int submesh, int meshlod) { }

	[Address(RVA = "0x3028EA0", Offset = "0x30282A0", Length = "0x50")]
	[Token(Token = "0x6000CC3")]
	private static uint GetTrianglesCountImpl_Injected(IntPtr _unity_self, int submesh, int meshlod) { }

	[Address(RVA = "0x3029000", Offset = "0x3028400", Length = "0x15D")]
	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	[Token(Token = "0x6000B4E")]
	private Int32[] GetTrianglesImpl(int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x3028F90", Offset = "0x3028390", Length = "0x62")]
	[Token(Token = "0x6000CC5")]
	private static void GetTrianglesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, int meshlod, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x30293B0", Offset = "0x30287B0", Length = "0x16E")]
	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B52")]
	private void GetTrianglesNonAllocImpl(out Int32[] values, int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x3029340", Offset = "0x3028740", Length = "0x64")]
	[Token(Token = "0x6000CC9")]
	private static void GetTrianglesNonAllocImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper values, int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x30291D0", Offset = "0x30285D0", Length = "0x16E")]
	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray16", HasExplicitThis = True)]
	[Token(Token = "0x6000B53")]
	private void GetTrianglesNonAllocImpl16(out UInt16[] values, int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x3029160", Offset = "0x3028560", Length = "0x64")]
	[Token(Token = "0x6000CCA")]
	private static void GetTrianglesNonAllocImpl16_Injected(IntPtr _unity_self, out BlittableArrayWrapper values, int submesh, bool applyBaseVertex, int meshlod) { }

	[Address(RVA = "0x302A010", Offset = "0x3029410", Length = "0x83")]
	[Token(Token = "0x6000BAE")]
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	[Address(RVA = "0x302A0E0", Offset = "0x30294E0", Length = "0x83")]
	[NativeMethod("GetMeshMetric")]
	[Token(Token = "0x6000BA9")]
	public float GetUVDistributionMetric(int uvSetIndex) { }

	[Address(RVA = "0x302A0A0", Offset = "0x30294A0", Length = "0x40")]
	[Token(Token = "0x6000D1A")]
	private static float GetUVDistributionMetric_Injected(IntPtr _unity_self, int uvSetIndex) { }

	[Address(RVA = "0x302A1E0", Offset = "0x30295E0", Length = "0x62")]
	[Token(Token = "0x6000C21")]
	public void GetUVs(int channel, List<Vector3> uvs) { }

	[Address(RVA = "0x302A170", Offset = "0x3029570", Length = "0x62")]
	[Token(Token = "0x6000C22")]
	public void GetUVs(int channel, List<Vector4> uvs) { }

	[Address(RVA = "0x302A250", Offset = "0x3029650", Length = "0x62")]
	[Token(Token = "0x6000C20")]
	public void GetUVs(int channel, List<Vector2> uvs) { }

	[Address(RVA = "0x8847A0", Offset = "0x883BA0", Length = "0x1D8")]
	[Token(Token = "0x6000C1F")]
	private void GetUVsImpl(int uvIndex, List<T> uvs, int dim) { }

	[Address(RVA = "0x302A710", Offset = "0x3029B10", Length = "0x9D")]
	[FreeFunction(Name = "MeshScripting::GetVertexAttributeByIndex", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B49")]
	public VertexAttributeDescriptor GetVertexAttribute(int index) { }

	[Address(RVA = "0x302A6C0", Offset = "0x3029AC0", Length = "0x50")]
	[Token(Token = "0x6000CC0")]
	private static void GetVertexAttribute_Injected(IntPtr _unity_self, int index, out VertexAttributeDescriptor ret) { }

	[Address(RVA = "0x302A300", Offset = "0x3029700", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::GetVertexAttributesCount", HasExplicitThis = True)]
	[Token(Token = "0x6000B48")]
	private int GetVertexAttributeCountImpl() { }

	[Address(RVA = "0x302A2C0", Offset = "0x30296C0", Length = "0x33")]
	[Token(Token = "0x6000CBF")]
	private static int GetVertexAttributeCountImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x302A3C0", Offset = "0x30297C0", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetChannelDimension", HasExplicitThis = True)]
	[Token(Token = "0x6000B58")]
	public int GetVertexAttributeDimension(VertexAttribute attr) { }

	[Address(RVA = "0x302A380", Offset = "0x3029780", Length = "0x40")]
	[Token(Token = "0x6000CCF")]
	private static int GetVertexAttributeDimension_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[Address(RVA = "0x302A490", Offset = "0x3029890", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetChannelFormat", HasExplicitThis = True)]
	[Token(Token = "0x6000B59")]
	public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { }

	[Address(RVA = "0x302A450", Offset = "0x3029850", Length = "0x40")]
	[Token(Token = "0x6000CD0")]
	private static VertexAttributeFormat GetVertexAttributeFormat_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[Address(RVA = "0x302A560", Offset = "0x3029960", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetChannelOffset", HasExplicitThis = True)]
	[Token(Token = "0x6000B5B")]
	public int GetVertexAttributeOffset(VertexAttribute attr) { }

	[Address(RVA = "0x302A520", Offset = "0x3029920", Length = "0x40")]
	[Token(Token = "0x6000CD2")]
	private static int GetVertexAttributeOffset_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[Address(RVA = "0x302AD40", Offset = "0x302A140", Length = "0xA")]
	[Token(Token = "0x6000C26")]
	public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes) { }

	[Address(RVA = "0x302A8C0", Offset = "0x3029CC0", Length = "0x126")]
	[Token(Token = "0x6000C25")]
	public int GetVertexAttributes(VertexAttributeDescriptor[] attributes) { }

	[Address(RVA = "0x302AC60", Offset = "0x302A060", Length = "0xD1")]
	[Token(Token = "0x6000C24")]
	public VertexAttributeDescriptor[] GetVertexAttributes() { }

	[Address(RVA = "0x302A7F0", Offset = "0x3029BF0", Length = "0x76")]
	[FreeFunction(Name = "MeshScripting::GetVertexAttributesAlloc", HasExplicitThis = True)]
	[Token(Token = "0x6000B45")]
	private Array GetVertexAttributesAlloc() { }

	[Address(RVA = "0x302A7B0", Offset = "0x3029BB0", Length = "0x33")]
	[Token(Token = "0x6000CBC")]
	private static Array GetVertexAttributesAlloc_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x302A8C0", Offset = "0x3029CC0", Length = "0x126")]
	[FreeFunction(Name = "MeshScripting::GetVertexAttributesArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B46")]
	private int GetVertexAttributesArray(VertexAttributeDescriptor[] attributes) { }

	[Address(RVA = "0x302A870", Offset = "0x3029C70", Length = "0x42")]
	[Token(Token = "0x6000CBD")]
	private static int GetVertexAttributesArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper attributes) { }

	[Address(RVA = "0x302AA40", Offset = "0x3029E40", Length = "0x215")]
	[FreeFunction(Name = "MeshScripting::GetVertexAttributesList", HasExplicitThis = True)]
	[Token(Token = "0x6000B47")]
	private int GetVertexAttributesList(List<VertexAttributeDescriptor> attributes) { }

	[Address(RVA = "0x302A9F0", Offset = "0x3029DF0", Length = "0x42")]
	[Token(Token = "0x6000CBE")]
	private static int GetVertexAttributesList_Injected(IntPtr _unity_self, ref BlittableListWrapper attributes) { }

	[Address(RVA = "0x302A630", Offset = "0x3029A30", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetChannelStream", HasExplicitThis = True)]
	[Token(Token = "0x6000B5A")]
	public int GetVertexAttributeStream(VertexAttribute attr) { }

	[Address(RVA = "0x302A5F0", Offset = "0x30299F0", Length = "0x40")]
	[Token(Token = "0x6000CD1")]
	private static int GetVertexAttributeStream_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[Address(RVA = "0x302AF10", Offset = "0x302A310", Length = "0x128")]
	[Token(Token = "0x6000C36")]
	public GraphicsBuffer GetVertexBuffer(int index) { }

	[Address(RVA = "0x302AD90", Offset = "0x302A190", Length = "0xA6")]
	[FreeFunction(Name = "MeshScripting::GetVertexBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B64")]
	private GraphicsBuffer GetVertexBufferImpl(int index) { }

	[Address(RVA = "0x302AD50", Offset = "0x302A150", Length = "0x40")]
	[Token(Token = "0x6000CDB")]
	private static IntPtr GetVertexBufferImpl_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x302AE80", Offset = "0x302A280", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::GetVertexBufferStride", HasExplicitThis = True)]
	[Token(Token = "0x6000B61")]
	public int GetVertexBufferStride(int stream) { }

	[Address(RVA = "0x302AE40", Offset = "0x302A240", Length = "0x40")]
	[Token(Token = "0x6000CD8")]
	private static int GetVertexBufferStride_Injected(IntPtr _unity_self, int stream) { }

	[Address(RVA = "0x302B040", Offset = "0x302A440", Length = "0x12B")]
	[Token(Token = "0x6000BD9")]
	public void GetVertices(List<Vector3> vertices) { }

	[Address(RVA = "0x302B1B0", Offset = "0x302A5B0", Length = "0x76")]
	[NativeMethod("HasBoneWeights")]
	[Token(Token = "0x6000B76")]
	private bool HasBoneWeights() { }

	[Address(RVA = "0x302B170", Offset = "0x302A570", Length = "0x33")]
	[Token(Token = "0x6000CEC")]
	private static bool HasBoneWeights_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x302B270", Offset = "0x302A670", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	[Token(Token = "0x6000B57")]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[Address(RVA = "0x302B230", Offset = "0x302A630", Length = "0x40")]
	[Token(Token = "0x6000CCE")]
	private static bool HasVertexAttribute_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[Address(RVA = "0x302B880", Offset = "0x302AC80", Length = "0x33")]
	[FreeFunction("MeshScripting::CreateMesh")]
	[Token(Token = "0x6000B38")]
	private static void Internal_Create(Mesh mono) { }

	[Address(RVA = "0x302B370", Offset = "0x302A770", Length = "0xA7")]
	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	[Token(Token = "0x6000B7A")]
	private void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	[Address(RVA = "0x302B300", Offset = "0x302A700", Length = "0x62")]
	[Token(Token = "0x6000CEF")]
	private static void InternalSetBoneWeights_Injected(IntPtr _unity_self, IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	[Address(RVA = "0x302B5B0", Offset = "0x302A9B0", Length = "0xA7")]
	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B3F")]
	private void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302B540", Offset = "0x302A940", Length = "0x62")]
	[Token(Token = "0x6000CB6")]
	private static void InternalSetIndexBufferData_Injected(IntPtr _unity_self, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302B490", Offset = "0x302A890", Length = "0xA7")]
	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B40")]
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302B420", Offset = "0x302A820", Length = "0x62")]
	[Token(Token = "0x6000CB7")]
	private static void InternalSetIndexBufferDataFromArray_Injected(IntPtr _unity_self, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302B7D0", Offset = "0x302ABD0", Length = "0xA7")]
	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferData", HasExplicitThis = True)]
	[Token(Token = "0x6000B43")]
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302B770", Offset = "0x302AB70", Length = "0x60")]
	[Token(Token = "0x6000CBA")]
	private static void InternalSetVertexBufferData_Injected(IntPtr _unity_self, int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302B6C0", Offset = "0x302AAC0", Length = "0xA7")]
	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = True)]
	[Token(Token = "0x6000B44")]
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302B660", Offset = "0x302AA60", Length = "0x60")]
	[Token(Token = "0x6000CBB")]
	private static void InternalSetVertexBufferDataFromArray_Injected(IntPtr _unity_self, int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302B980", Offset = "0x302AD80", Length = "0xD1")]
	[Token(Token = "0x6000CA7")]
	public void MarkDynamic() { }

	[Address(RVA = "0x302B900", Offset = "0x302AD00", Length = "0x76")]
	[NativeMethod("MarkDynamic")]
	[Token(Token = "0x6000BA3")]
	private void MarkDynamicImpl() { }

	[Address(RVA = "0x302B8C0", Offset = "0x302ACC0", Length = "0x33")]
	[Token(Token = "0x6000D14")]
	private static void MarkDynamicImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x302BAA0", Offset = "0x302AEA0", Length = "0x76")]
	[NativeMethod("MarkModified")]
	[Token(Token = "0x6000BA4")]
	public void MarkModified() { }

	[Address(RVA = "0x302BA60", Offset = "0x302AE60", Length = "0x33")]
	[Token(Token = "0x6000D15")]
	private static void MarkModified_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x302C000", Offset = "0x302B400", Length = "0x142")]
	[Token(Token = "0x6000CA9")]
	public void Optimize() { }

	[Address(RVA = "0x302BB60", Offset = "0x302AF60", Length = "0x76")]
	[NativeMethod("Optimize")]
	[Token(Token = "0x6000BAB")]
	private void OptimizeImpl() { }

	[Address(RVA = "0x302BB20", Offset = "0x302AF20", Length = "0x33")]
	[Token(Token = "0x6000D1C")]
	private static void OptimizeImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x302BCA0", Offset = "0x302B0A0", Length = "0x142")]
	[Token(Token = "0x6000CAA")]
	public void OptimizeIndexBuffers() { }

	[Address(RVA = "0x302BC20", Offset = "0x302B020", Length = "0x76")]
	[NativeMethod("OptimizeIndexBuffers")]
	[Token(Token = "0x6000BAC")]
	private void OptimizeIndexBuffersImpl() { }

	[Address(RVA = "0x302BBE0", Offset = "0x302AFE0", Length = "0x33")]
	[Token(Token = "0x6000D1D")]
	private static void OptimizeIndexBuffersImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x302BEB0", Offset = "0x302B2B0", Length = "0x142")]
	[Token(Token = "0x6000CAB")]
	public void OptimizeReorderVertexBuffer() { }

	[Address(RVA = "0x302BE30", Offset = "0x302B230", Length = "0x76")]
	[NativeMethod("OptimizeReorderVertexBuffer")]
	[Token(Token = "0x6000BAD")]
	private void OptimizeReorderVertexBufferImpl() { }

	[Address(RVA = "0x302BDF0", Offset = "0x302B1F0", Length = "0x33")]
	[Token(Token = "0x6000D1E")]
	private static void OptimizeReorderVertexBufferImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x302C190", Offset = "0x302B590", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	[Token(Token = "0x6000B56")]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[Address(RVA = "0x302C150", Offset = "0x302B550", Length = "0x40")]
	[Token(Token = "0x6000CCD")]
	private static void PrintErrorCantAccessChannel_Injected(IntPtr _unity_self, VertexAttribute ch) { }

	[Address(RVA = "0x302C220", Offset = "0x302B620", Length = "0x74")]
	[Token(Token = "0x6000C3C")]
	private void PrintErrorCantAccessIndices() { }

	[Address(RVA = "0x302C4C0", Offset = "0x302B8C0", Length = "0x154")]
	[Token(Token = "0x6000CA2")]
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	[Address(RVA = "0x302C370", Offset = "0x302B770", Length = "0x144")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C9F")]
	public void RecalculateBounds() { }

	[Address(RVA = "0x302C2E0", Offset = "0x302B6E0", Length = "0x83")]
	[NativeMethod("RecalculateBounds")]
	[Token(Token = "0x6000BA0")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[Address(RVA = "0x302C2A0", Offset = "0x302B6A0", Length = "0x40")]
	[Token(Token = "0x6000D11")]
	private static void RecalculateBoundsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302C6F0", Offset = "0x302BAF0", Length = "0x144")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000CA0")]
	public void RecalculateNormals() { }

	[Address(RVA = "0x302C840", Offset = "0x302BC40", Length = "0x154")]
	[Token(Token = "0x6000CA3")]
	public void RecalculateNormals(MeshUpdateFlags flags) { }

	[Address(RVA = "0x302C660", Offset = "0x302BA60", Length = "0x83")]
	[NativeMethod("RecalculateNormals")]
	[Token(Token = "0x6000BA1")]
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	[Address(RVA = "0x302C620", Offset = "0x302BA20", Length = "0x40")]
	[Token(Token = "0x6000D12")]
	private static void RecalculateNormalsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302CBC0", Offset = "0x302BFC0", Length = "0x154")]
	[Token(Token = "0x6000CA4")]
	public void RecalculateTangents(MeshUpdateFlags flags) { }

	[Address(RVA = "0x302CA70", Offset = "0x302BE70", Length = "0x144")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000CA1")]
	public void RecalculateTangents() { }

	[Address(RVA = "0x302C9E0", Offset = "0x302BDE0", Length = "0x83")]
	[NativeMethod("RecalculateTangents")]
	[Token(Token = "0x6000BA2")]
	private void RecalculateTangentsImpl(MeshUpdateFlags flags) { }

	[Address(RVA = "0x302C9A0", Offset = "0x302BDA0", Length = "0x40")]
	[Token(Token = "0x6000D13")]
	private static void RecalculateTangentsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302CE10", Offset = "0x302C210", Length = "0x156")]
	[Token(Token = "0x6000CA5")]
	public void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold = 1E-09) { }

	[Address(RVA = "0x302CD70", Offset = "0x302C170", Length = "0x93")]
	[NativeMethod("RecalculateMeshMetric")]
	[Token(Token = "0x6000BA7")]
	private void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold) { }

	[Address(RVA = "0x302CD20", Offset = "0x302C120", Length = "0x50")]
	[Token(Token = "0x6000D18")]
	private static void RecalculateUVDistributionMetricImpl_Injected(IntPtr _unity_self, int uvSetIndex, float uvAreaThreshold) { }

	[Address(RVA = "0x302D050", Offset = "0x302C450", Length = "0x157")]
	[Token(Token = "0x6000CA6")]
	public void RecalculateUVDistributionMetrics(float uvAreaThreshold = 1E-09) { }

	[Address(RVA = "0x302CFC0", Offset = "0x302C3C0", Length = "0x86")]
	[NativeMethod("RecalculateMeshMetrics")]
	[Token(Token = "0x6000BA8")]
	private void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold) { }

	[Address(RVA = "0x302CF70", Offset = "0x302C370", Length = "0x43")]
	[Token(Token = "0x6000D19")]
	private static void RecalculateUVDistributionMetricsImpl_Injected(IntPtr _unity_self, float uvAreaThreshold) { }

	[Address(RVA = "0x3035020", Offset = "0x3034420", Length = "0x104")]
	[Token(Token = "0x6000B83")]
	public void set_bindposes(Matrix4x4[] value) { }

	[Address(RVA = "0x3034FD0", Offset = "0x30343D0", Length = "0x42")]
	[Token(Token = "0x6000CF6")]
	private static void set_bindposes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x302D840", Offset = "0x302CC40", Length = "0x104")]
	[Token(Token = "0x6000C9B")]
	public void set_boneWeights(BoneWeight[] value) { }

	[Address(RVA = "0x3035180", Offset = "0x3034580", Length = "0x85")]
	[Token(Token = "0x6000B9E")]
	public void set_bounds(Bounds value) { }

	[Address(RVA = "0x3035130", Offset = "0x3034530", Length = "0x42")]
	[Token(Token = "0x6000D0F")]
	private static void set_bounds_Injected(IntPtr _unity_self, in Bounds value) { }

	[Address(RVA = "0x3035280", Offset = "0x3034680", Length = "0x56")]
	[Token(Token = "0x6000BD1")]
	public void set_colors(Color[] value) { }

	[Address(RVA = "0x3035210", Offset = "0x3034610", Length = "0x69")]
	[Token(Token = "0x6000BD3")]
	public void set_colors32(Color32[] value) { }

	[Address(RVA = "0x3035320", Offset = "0x3034720", Length = "0x83")]
	[Token(Token = "0x6000B6B")]
	public void set_indexBufferTarget(Target value) { }

	[Address(RVA = "0x30352E0", Offset = "0x30346E0", Length = "0x40")]
	[Token(Token = "0x6000CE2")]
	private static void set_indexBufferTarget_Injected(IntPtr _unity_self, Target value) { }

	[Address(RVA = "0x30353F0", Offset = "0x30347F0", Length = "0x83")]
	[Token(Token = "0x6000B3C")]
	public void set_indexFormat(IndexFormat value) { }

	[Address(RVA = "0x30353B0", Offset = "0x30347B0", Length = "0x40")]
	[Token(Token = "0x6000CB3")]
	private static void set_indexFormat_Injected(IntPtr _unity_self, IndexFormat value) { }

	[Address(RVA = "0x3035480", Offset = "0x3034880", Length = "0x218")]
	[Token(Token = "0x6000BD5")]
	public void set_lodCount(int value) { }

	[Address(RVA = "0x30356A0", Offset = "0x3034AA0", Length = "0x80")]
	[Token(Token = "0x6000BD8")]
	public void set_lodSelectionCurve(LodSelectionCurve value) { }

	[Address(RVA = "0x3035730", Offset = "0x3034B30", Length = "0x56")]
	[Token(Token = "0x6000BBD")]
	public void set_normals(Vector3[] value) { }

	[Address(RVA = "0x30357D0", Offset = "0x3034BD0", Length = "0x83")]
	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	[Token(Token = "0x6000B8E")]
	public void set_subMeshCount(int value) { }

	[Address(RVA = "0x3035790", Offset = "0x3034B90", Length = "0x40")]
	[Token(Token = "0x6000CFF")]
	private static void set_subMeshCount_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3035860", Offset = "0x3034C60", Length = "0x56")]
	[Token(Token = "0x6000BBF")]
	public void set_tangents(Vector4[] value) { }

	[Address(RVA = "0x30358C0", Offset = "0x3034CC0", Length = "0x15F")]
	[Token(Token = "0x6000C41")]
	public void set_triangles(Int32[] value) { }

	[Address(RVA = "0x3035CC0", Offset = "0x30350C0", Length = "0x56")]
	[Token(Token = "0x6000BC1")]
	public void set_uv(Vector2[] value) { }

	[Address(RVA = "0x3035A20", Offset = "0x3034E20", Length = "0x56")]
	[Token(Token = "0x6000BC3")]
	public void set_uv2(Vector2[] value) { }

	[Address(RVA = "0x3035A80", Offset = "0x3034E80", Length = "0x56")]
	[Token(Token = "0x6000BC5")]
	public void set_uv3(Vector2[] value) { }

	[Address(RVA = "0x3035AE0", Offset = "0x3034EE0", Length = "0x56")]
	[Token(Token = "0x6000BC7")]
	public void set_uv4(Vector2[] value) { }

	[Address(RVA = "0x3035B40", Offset = "0x3034F40", Length = "0x56")]
	[Token(Token = "0x6000BC9")]
	public void set_uv5(Vector2[] value) { }

	[Address(RVA = "0x3035BA0", Offset = "0x3034FA0", Length = "0x56")]
	[Token(Token = "0x6000BCB")]
	public void set_uv6(Vector2[] value) { }

	[Address(RVA = "0x3035C00", Offset = "0x3035000", Length = "0x56")]
	[Token(Token = "0x6000BCD")]
	public void set_uv7(Vector2[] value) { }

	[Address(RVA = "0x3035C60", Offset = "0x3035060", Length = "0x56")]
	[Token(Token = "0x6000BCF")]
	public void set_uv8(Vector2[] value) { }

	[Address(RVA = "0x3035D60", Offset = "0x3035160", Length = "0x83")]
	[Token(Token = "0x6000B69")]
	public void set_vertexBufferTarget(Target value) { }

	[Address(RVA = "0x3035D20", Offset = "0x3035120", Length = "0x40")]
	[Token(Token = "0x6000CE0")]
	private static void set_vertexBufferTarget_Injected(IntPtr _unity_self, Target value) { }

	[Address(RVA = "0x3035DF0", Offset = "0x30351F0", Length = "0x53")]
	[Token(Token = "0x6000BBB")]
	public void set_vertices(Vector3[] value) { }

	[Address(RVA = "0x302D220", Offset = "0x302C620", Length = "0x131")]
	[FreeFunction("MeshScripting::SetAllSubMeshesAtOnceFromArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B91")]
	private void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302D1B0", Offset = "0x302C5B0", Length = "0x62")]
	[Token(Token = "0x6000D02")]
	private static void SetAllSubMeshesAtOnceFromArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper desc, int start, int count, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302D3D0", Offset = "0x302C7D0", Length = "0xA7")]
	[FreeFunction("MeshScripting::SetAllSubMeshesAtOnceFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B92")]
	private void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302D360", Offset = "0x302C760", Length = "0x62")]
	[Token(Token = "0x6000D03")]
	private static void SetAllSubMeshesAtOnceFromNativeArray_Injected(IntPtr _unity_self, IntPtr desc, int start, int count, MeshUpdateFlags flags) { }

	[Address(RVA = "0x884A10", Offset = "0x883E10", Length = "0x81")]
	[Token(Token = "0x6000BB5")]
	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x884980", Offset = "0x883D80", Length = "0x87")]
	[Token(Token = "0x6000BB4")]
	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302D4E0", Offset = "0x302C8E0", Length = "0xA7")]
	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000B5C")]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302D480", Offset = "0x302C880", Length = "0x60")]
	[Token(Token = "0x6000CD3")]
	private static void SetArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302D690", Offset = "0x302CA90", Length = "0x156")]
	[Token(Token = "0x6000B85")]
	public void SetBindposes(NativeArray<Matrix4x4> poses) { }

	[Address(RVA = "0x302D5F0", Offset = "0x302C9F0", Length = "0x95")]
	[NativeMethod("SetBindposes")]
	[Token(Token = "0x6000B86")]
	private void SetBindposesFromScript_NativeArray(IntPtr posesPtr, int posesCount) { }

	[Address(RVA = "0x302D590", Offset = "0x302C990", Length = "0x52")]
	[Token(Token = "0x6000CF7")]
	private static void SetBindposesFromScript_NativeArray_Injected(IntPtr _unity_self, IntPtr posesPtr, int posesCount) { }

	[Address(RVA = "0x302D950", Offset = "0x302CD50", Length = "0x11E")]
	[Token(Token = "0x6000B79")]
	public void SetBoneWeights(NativeArray<Byte> bonesPerVertex, NativeArray<BoneWeight1> weights) { }

	[Address(RVA = "0x302D840", Offset = "0x302CC40", Length = "0x104")]
	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	[Token(Token = "0x6000B78")]
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	[Address(RVA = "0x302D7F0", Offset = "0x302CBF0", Length = "0x42")]
	[Token(Token = "0x6000CEE")]
	private static void SetBoneWeightsImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper weights) { }

	[Address(RVA = "0x884AA0", Offset = "0x883EA0", Length = "0x7E")]
	[Token(Token = "0x6000C05")]
	public void SetColors(NativeArray<T> inColors) { }

	[Address(RVA = "0x302DCA0", Offset = "0x302D0A0", Length = "0x7F")]
	[Token(Token = "0x6000C04")]
	public void SetColors(Color32[] inColors, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302DE90", Offset = "0x302D290", Length = "0x74")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C03")]
	public void SetColors(Color32[] inColors, int start, int length) { }

	[Address(RVA = "0x302DC30", Offset = "0x302D030", Length = "0x70")]
	[Token(Token = "0x6000C02")]
	public void SetColors(Color32[] inColors) { }

	[Address(RVA = "0x302DA70", Offset = "0x302CE70", Length = "0x8E")]
	[Token(Token = "0x6000C01")]
	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302DB80", Offset = "0x302CF80", Length = "0xA6")]
	[Token(Token = "0x6000BFF")]
	public void SetColors(List<Color32> inColors) { }

	[Address(RVA = "0x302DE10", Offset = "0x302D210", Length = "0x7C")]
	[Token(Token = "0x6000BFD")]
	public void SetColors(Color[] inColors, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302E020", Offset = "0x302D420", Length = "0x99")]
	[Token(Token = "0x6000BF8")]
	public void SetColors(List<Color> inColors) { }

	[Address(RVA = "0x302DD20", Offset = "0x302D120", Length = "0x7C")]
	[Token(Token = "0x6000BFA")]
	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x884C80", Offset = "0x884080", Length = "0x86")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C06")]
	public void SetColors(NativeArray<T> inColors, int start, int length) { }

	[Address(RVA = "0x302DDA0", Offset = "0x302D1A0", Length = "0x6D")]
	[Token(Token = "0x6000BFB")]
	public void SetColors(Color[] inColors) { }

	[Address(RVA = "0x302DF10", Offset = "0x302D310", Length = "0x71")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BFC")]
	public void SetColors(Color[] inColors, int start, int length) { }

	[Address(RVA = "0x302DF90", Offset = "0x302D390", Length = "0x8B")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C00")]
	public void SetColors(List<Color32> inColors, int start, int length) { }

	[Address(RVA = "0x884B20", Offset = "0x883F20", Length = "0x151")]
	[Token(Token = "0x6000C07")]
	public void SetColors(NativeArray<T> inColors, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302DB00", Offset = "0x302CF00", Length = "0x7C")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BF9")]
	public void SetColors(List<Color> inColors, int start, int length) { }

	[Address(RVA = "0x8850E0", Offset = "0x8844E0", Length = "0x299")]
	[Token(Token = "0x6000C54")]
	public void SetIndexBufferData(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x884D10", Offset = "0x884110", Length = "0x1F3")]
	[Token(Token = "0x6000C53")]
	public void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x885380", Offset = "0x884780", Length = "0x171")]
	[Token(Token = "0x6000C52")]
	public void SetIndexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302E110", Offset = "0x302D510", Length = "0x93")]
	[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B3E")]
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	[Address(RVA = "0x302E0C0", Offset = "0x302D4C0", Length = "0x50")]
	[Token(Token = "0x6000CB5")]
	private static void SetIndexBufferParams_Injected(IntPtr _unity_self, int indexCount, IndexFormat format) { }

	[Address(RVA = "0x302E490", Offset = "0x302D890", Length = "0x129")]
	[Token(Token = "0x6000C75")]
	public void SetIndices(Int32[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x8859F0", Offset = "0x884DF0", Length = "0xE5")]
	[Token(Token = "0x6000C7D")]
	public void SetIndices(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x885AE0", Offset = "0x884EE0", Length = "0xF7")]
	[Token(Token = "0x6000C7C")]
	public void SetIndices(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x885500", Offset = "0x884900", Length = "0xC9")]
	[Token(Token = "0x6000C7B")]
	public void SetIndices(NativeArray<T> indices, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x8858F0", Offset = "0x884CF0", Length = "0xFF")]
	[Token(Token = "0x6000C7A")]
	public void SetIndices(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302EE60", Offset = "0x302E260", Length = "0x126")]
	[Token(Token = "0x6000C79")]
	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302EE10", Offset = "0x302E210", Length = "0x48")]
	[Token(Token = "0x6000C78")]
	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302E610", Offset = "0x302DA10", Length = "0x6C")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C70")]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh) { }

	[Address(RVA = "0x302E410", Offset = "0x302D810", Length = "0x7E")]
	[Token(Token = "0x6000C76")]
	public void SetIndices(UInt16[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302E680", Offset = "0x302DA80", Length = "0x9B")]
	[Token(Token = "0x6000C7E")]
	public void SetIndices(List<Int32> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302E5C0", Offset = "0x302D9C0", Length = "0x48")]
	[Token(Token = "0x6000C74")]
	public void SetIndices(Int32[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302F010", Offset = "0x302E410", Length = "0x89")]
	[Token(Token = "0x6000C73")]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302ED90", Offset = "0x302E190", Length = "0x7E")]
	[Token(Token = "0x6000C72")]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	[Address(RVA = "0x302ED00", Offset = "0x302E100", Length = "0x89")]
	[Token(Token = "0x6000C77")]
	public void SetIndices(UInt16[] indices, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302E9B0", Offset = "0x302DDB0", Length = "0xA4")]
	[Token(Token = "0x6000C7F")]
	public void SetIndices(List<Int32> indices, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302EF90", Offset = "0x302E390", Length = "0x75")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C71")]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	[Address(RVA = "0x302EAB0", Offset = "0x302DEB0", Length = "0x196")]
	[Token(Token = "0x6000C81")]
	public void SetIndices(List<Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302E720", Offset = "0x302DB20", Length = "0x9B")]
	[Token(Token = "0x6000C82")]
	public void SetIndices(List<UInt16> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302EC50", Offset = "0x302E050", Length = "0xA4")]
	[Token(Token = "0x6000C83")]
	public void SetIndices(List<UInt16> indices, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302EA60", Offset = "0x302DE60", Length = "0x48")]
	[Token(Token = "0x6000C84")]
	public void SetIndices(List<UInt16> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302E810", Offset = "0x302DC10", Length = "0x193")]
	[Token(Token = "0x6000C85")]
	public void SetIndices(List<UInt16> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302E7C0", Offset = "0x302DBC0", Length = "0x48")]
	[Token(Token = "0x6000C80")]
	public void SetIndices(List<Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x302E220", Offset = "0x302D620", Length = "0xB6")]
	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B50")]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex, int meshlod) { }

	[Address(RVA = "0x302E1B0", Offset = "0x302D5B0", Length = "0x6F")]
	[Token(Token = "0x6000CC7")]
	private static void SetIndicesImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex, int meshlod) { }

	[Address(RVA = "0x302E350", Offset = "0x302D750", Length = "0xB6")]
	[FreeFunction(Name = "SetMeshIndicesFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B51")]
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex, int meshlod) { }

	[Address(RVA = "0x302E2E0", Offset = "0x302D6E0", Length = "0x6F")]
	[Token(Token = "0x6000CC8")]
	private static void SetIndicesNativeArrayImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex, int meshlod) { }

	[Address(RVA = "0x885CE0", Offset = "0x8850E0", Length = "0xF6")]
	[Token(Token = "0x6000BB7")]
	private void SetListForChannel(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x885BE0", Offset = "0x884FE0", Length = "0xFB")]
	[Token(Token = "0x6000BB6")]
	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302F360", Offset = "0x302E760", Length = "0x1AD")]
	[Token(Token = "0x6000C8F")]
	public void SetLod(int submesh, int level, MeshLodRange levelRange, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302F0E0", Offset = "0x302E4E0", Length = "0x83")]
	[FreeFunction("MeshScripting::SetLodCount", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B93")]
	private void SetLodCount(int numLevels) { }

	[Address(RVA = "0x302F0A0", Offset = "0x302E4A0", Length = "0x40")]
	[Token(Token = "0x6000D04")]
	private static void SetLodCount_Injected(IntPtr _unity_self, int numLevels) { }

	[Address(RVA = "0x302F1D0", Offset = "0x302E5D0", Length = "0xA5")]
	[FreeFunction("MeshScripting::SetLod", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B97")]
	private void SetLodImpl(int subMeshIndex, int level, MeshLodRange levelRange, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302F170", Offset = "0x302E570", Length = "0x60")]
	[Token(Token = "0x6000D08")]
	private static void SetLodImpl_Injected(IntPtr _unity_self, int subMeshIndex, int level, in MeshLodRange levelRange, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302FA20", Offset = "0x302EE20", Length = "0x3B0")]
	[Token(Token = "0x6000C93")]
	public void SetLods(MeshLodRange[] levels, int start, int count, int submesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302FFD0", Offset = "0x302F3D0", Length = "0x418")]
	[Token(Token = "0x6000C91")]
	public void SetLods(List<MeshLodRange> levels, int start, int count, int submesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x30303F0", Offset = "0x302F7F0", Length = "0x254")]
	[Token(Token = "0x6000C90")]
	public void SetLods(List<MeshLodRange> levels, int submesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302F7E0", Offset = "0x302EBE0", Length = "0x235")]
	[Token(Token = "0x6000C94")]
	public void SetLods(NativeArray<MeshLodRange> levels, int submesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x3030650", Offset = "0x302FA50", Length = "0x40B")]
	[Token(Token = "0x6000C95")]
	public void SetLods(NativeArray<MeshLodRange> levels, int start, int count, int submesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302FDE0", Offset = "0x302F1E0", Length = "0x1EC")]
	[Token(Token = "0x6000C92")]
	public void SetLods(MeshLodRange[] levels, int submesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302F2D0", Offset = "0x302E6D0", Length = "0x80")]
	[FreeFunction("MeshScripting::SetLodSelectionCurve", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B94")]
	private void SetLodSelectionCurve(LodSelectionCurve lodSelectionCurve) { }

	[Address(RVA = "0x302F280", Offset = "0x302E680", Length = "0x42")]
	[Token(Token = "0x6000D05")]
	private static void SetLodSelectionCurve_Injected(IntPtr _unity_self, in LodSelectionCurve lodSelectionCurve) { }

	[Address(RVA = "0x302F580", Offset = "0x302E980", Length = "0x13C")]
	[FreeFunction("MeshScripting::SetLods", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B95")]
	private void SetLodsFromArray(MeshLodRange[] levelRanges, int start, int count, int submesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302F510", Offset = "0x302E910", Length = "0x62")]
	[Token(Token = "0x6000D06")]
	private static void SetLodsFromArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper levelRanges, int start, int count, int submesh, MeshUpdateFlags flags) { }

	[Address(RVA = "0x302F730", Offset = "0x302EB30", Length = "0xA7")]
	[FreeFunction("MeshScripting::SetLodsFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B96")]
	private void SetLodsFromNativeArray(IntPtr lodLevels, int count, int submesh, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x302F6C0", Offset = "0x302EAC0", Length = "0x62")]
	[Token(Token = "0x6000D07")]
	private static void SetLodsFromNativeArray_Injected(IntPtr _unity_self, IntPtr lodLevels, int count, int submesh, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3030AC0", Offset = "0x302FEC0", Length = "0xA7")]
	[FreeFunction(Name = "SetMeshComponentFromNativeArrayFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000B5D")]
	private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3030A60", Offset = "0x302FE60", Length = "0x60")]
	[Token(Token = "0x6000CD4")]
	private static void SetNativeArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3030C60", Offset = "0x3030060", Length = "0x7C")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BE5")]
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	[Address(RVA = "0x3030B70", Offset = "0x302FF70", Length = "0x7C")]
	[Token(Token = "0x6000BE6")]
	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3030D60", Offset = "0x3030160", Length = "0x99")]
	[Token(Token = "0x6000BE4")]
	public void SetNormals(List<Vector3> inNormals) { }

	[Address(RVA = "0x3030CE0", Offset = "0x30300E0", Length = "0x71")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BE8")]
	public void SetNormals(Vector3[] inNormals, int start, int length) { }

	[Address(RVA = "0x3030E00", Offset = "0x3030200", Length = "0x7C")]
	[Token(Token = "0x6000BE9")]
	public void SetNormals(Vector3[] inNormals, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x884AA0", Offset = "0x883EA0", Length = "0x7E")]
	[Token(Token = "0x6000BEA")]
	public void SetNormals(NativeArray<T> inNormals) { }

	[Address(RVA = "0x884C80", Offset = "0x884080", Length = "0x86")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BEB")]
	public void SetNormals(NativeArray<T> inNormals, int start, int length) { }

	[Address(RVA = "0x3030BF0", Offset = "0x302FFF0", Length = "0x6D")]
	[Token(Token = "0x6000BE7")]
	public void SetNormals(Vector3[] inNormals) { }

	[Address(RVA = "0x885FA0", Offset = "0x8853A0", Length = "0x12A")]
	[Token(Token = "0x6000BEC")]
	public void SetNormals(NativeArray<T> inNormals, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3030E80", Offset = "0x3030280", Length = "0x3E2")]
	[Token(Token = "0x6000BB2")]
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3031270", Offset = "0x3030670", Length = "0x3DE")]
	[Token(Token = "0x6000BB3")]
	private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[Address(RVA = "0x30316B0", Offset = "0x3030AB0", Length = "0xA7")]
	[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B8F")]
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x3031650", Offset = "0x3030A50", Length = "0x60")]
	[Token(Token = "0x6000D00")]
	private static void SetSubMesh_Injected(IntPtr _unity_self, int index, in SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	[Address(RVA = "0x8863D0", Offset = "0x8857D0", Length = "0x266")]
	[Token(Token = "0x6000C8A")]
	public void SetSubMeshes(NativeArray<T> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x886340", Offset = "0x885740", Length = "0x8F")]
	[Token(Token = "0x6000C8B")]
	public void SetSubMeshes(NativeArray<T> desc, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x3031820", Offset = "0x3030C20", Length = "0x3C")]
	[Token(Token = "0x6000C87")]
	public void SetSubMeshes(SubMeshDescriptor[] desc, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x3031760", Offset = "0x3030B60", Length = "0xB0")]
	[Token(Token = "0x6000C88")]
	public void SetSubMeshes(List<SubMeshDescriptor> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x3031920", Offset = "0x3030D20", Length = "0x4C3")]
	[Token(Token = "0x6000C86")]
	public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x3031860", Offset = "0x3030C60", Length = "0xBB")]
	[Token(Token = "0x6000C89")]
	public void SetSubMeshes(List<SubMeshDescriptor> desc, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x3031DF0", Offset = "0x30311F0", Length = "0x99")]
	[Token(Token = "0x6000BEE")]
	public void SetTangents(List<Vector4> inTangents) { }

	[Address(RVA = "0x3032010", Offset = "0x3031410", Length = "0x7C")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BEF")]
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	[Address(RVA = "0x3032090", Offset = "0x3031490", Length = "0x6D")]
	[Token(Token = "0x6000BF1")]
	public void SetTangents(Vector4[] inTangents) { }

	[Address(RVA = "0x3031F10", Offset = "0x3031310", Length = "0x7C")]
	[Token(Token = "0x6000BF0")]
	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3031F90", Offset = "0x3031390", Length = "0x7C")]
	[Token(Token = "0x6000BF3")]
	public void SetTangents(Vector4[] inTangents, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x884AA0", Offset = "0x883EA0", Length = "0x7E")]
	[Token(Token = "0x6000BF4")]
	public void SetTangents(NativeArray<T> inTangents) { }

	[Address(RVA = "0x884C80", Offset = "0x884080", Length = "0x86")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BF5")]
	public void SetTangents(NativeArray<T> inTangents, int start, int length) { }

	[Address(RVA = "0x886640", Offset = "0x885A40", Length = "0x12A")]
	[Token(Token = "0x6000BF6")]
	public void SetTangents(NativeArray<T> inTangents, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3031E90", Offset = "0x3031290", Length = "0x71")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BF2")]
	public void SetTangents(Vector4[] inTangents, int start, int length) { }

	[Address(RVA = "0x3032C20", Offset = "0x3032020", Length = "0x3D")]
	[Token(Token = "0x6000C60")]
	public void SetTriangles(Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032290", Offset = "0x3031690", Length = "0x68")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C5D")]
	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds) { }

	[Address(RVA = "0x3032A40", Offset = "0x3031E40", Length = "0x71")]
	[Token(Token = "0x6000C5E")]
	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	[Address(RVA = "0x3032300", Offset = "0x3031700", Length = "0x7C")]
	[Token(Token = "0x6000C5F")]
	public void SetTriangles(Int32[] triangles, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x30324D0", Offset = "0x30318D0", Length = "0xAA")]
	[Token(Token = "0x6000C61")]
	public void SetTriangles(Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032B80", Offset = "0x3031F80", Length = "0x5B")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C5C")]
	public void SetTriangles(Int32[] triangles, int submesh) { }

	[Address(RVA = "0x3032580", Offset = "0x3031980", Length = "0x7C")]
	[Token(Token = "0x6000C63")]
	public void SetTriangles(UInt16[] triangles, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x30327E0", Offset = "0x3031BE0", Length = "0x125")]
	[Token(Token = "0x6000C6F")]
	public void SetTriangles(List<UInt16> triangles, int trianglesStart, int trianglesLength, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032740", Offset = "0x3031B40", Length = "0x91")]
	[Token(Token = "0x6000C6C")]
	public void SetTriangles(List<UInt16> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032600", Offset = "0x3031A00", Length = "0x71")]
	[Token(Token = "0x6000C62")]
	public void SetTriangles(UInt16[] triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032910", Offset = "0x3031D10", Length = "0x128")]
	[Token(Token = "0x6000C6B")]
	public void SetTriangles(List<Int32> triangles, int trianglesStart, int trianglesLength, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032680", Offset = "0x3031A80", Length = "0x99")]
	[Token(Token = "0x6000C6D")]
	public void SetTriangles(List<UInt16> triangles, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032380", Offset = "0x3031780", Length = "0x99")]
	[Token(Token = "0x6000C69")]
	public void SetTriangles(List<Int32> triangles, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032AC0", Offset = "0x3031EC0", Length = "0x91")]
	[Token(Token = "0x6000C68")]
	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	[Address(RVA = "0x3032210", Offset = "0x3031610", Length = "0x3D")]
	[Token(Token = "0x6000C6A")]
	public void SetTriangles(List<Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032720", Offset = "0x3031B20", Length = "0x19")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C67")]
	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds) { }

	[Address(RVA = "0x3032B60", Offset = "0x3031F60", Length = "0x1C")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C66")]
	public void SetTriangles(List<Int32> triangles, int submesh) { }

	[Address(RVA = "0x3032420", Offset = "0x3031820", Length = "0xA7")]
	[Token(Token = "0x6000C65")]
	public void SetTriangles(UInt16[] triangles, int trianglesStart, int trianglesLength, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032250", Offset = "0x3031650", Length = "0x3D")]
	[Token(Token = "0x6000C64")]
	public void SetTriangles(UInt16[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032BE0", Offset = "0x3031FE0", Length = "0x3D")]
	[Token(Token = "0x6000C6E")]
	public void SetTriangles(List<UInt16> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[Address(RVA = "0x3032100", Offset = "0x3031500", Length = "0x102")]
	[Token(Token = "0x6000C5B")]
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex, int meshLod) { }

	[Address(RVA = "0x886770", Offset = "0x885B70", Length = "0x218")]
	[Token(Token = "0x6000C1E")]
	public void SetUVs(int channel, NativeArray<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3032C90", Offset = "0x3032090", Length = "0x83")]
	[Token(Token = "0x6000C11")]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3032FA0", Offset = "0x30323A0", Length = "0x83")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C10")]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	[Address(RVA = "0x3032D20", Offset = "0x3032120", Length = "0x83")]
	[Token(Token = "0x6000C0F")]
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3032DB0", Offset = "0x30321B0", Length = "0x83")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C0E")]
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	[Address(RVA = "0x3033090", Offset = "0x3032490", Length = "0x57")]
	[Token(Token = "0x6000C14")]
	public void SetUVs(int channel, Vector3[] uvs) { }

	[Address(RVA = "0x886A20", Offset = "0x885E20", Length = "0x92")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C1D")]
	public void SetUVs(int channel, NativeArray<T> uvs, int start, int length) { }

	[Address(RVA = "0x30332F0", Offset = "0x30326F0", Length = "0x57")]
	[Token(Token = "0x6000C15")]
	public void SetUVs(int channel, Vector4[] uvs) { }

	[Address(RVA = "0x3033030", Offset = "0x3032430", Length = "0x57")]
	[Token(Token = "0x6000C13")]
	public void SetUVs(int channel, Vector2[] uvs) { }

	[Address(RVA = "0x3032E80", Offset = "0x3032280", Length = "0x35")]
	[Token(Token = "0x6000C17")]
	public void SetUVs(int channel, Vector2[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3032F70", Offset = "0x3032370", Length = "0x2F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C16")]
	public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }

	[Address(RVA = "0x3032C60", Offset = "0x3032060", Length = "0x2F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C18")]
	public void SetUVs(int channel, Vector3[] uvs, int start, int length) { }

	[Address(RVA = "0x30330F0", Offset = "0x30324F0", Length = "0x83")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C0C")]
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	[Address(RVA = "0x3033180", Offset = "0x3032580", Length = "0xA7")]
	[Token(Token = "0x6000C0B")]
	public void SetUVs(int channel, List<Vector4> uvs) { }

	[Address(RVA = "0x3033390", Offset = "0x3032790", Length = "0xA7")]
	[Token(Token = "0x6000C0A")]
	public void SetUVs(int channel, List<Vector3> uvs) { }

	[Address(RVA = "0x3032EC0", Offset = "0x30322C0", Length = "0xA7")]
	[Token(Token = "0x6000C09")]
	public void SetUVs(int channel, List<Vector2> uvs) { }

	[Address(RVA = "0x3033350", Offset = "0x3032750", Length = "0x35")]
	[Token(Token = "0x6000C19")]
	public void SetUVs(int channel, Vector3[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3033230", Offset = "0x3032630", Length = "0x2F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000C1A")]
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	[Address(RVA = "0x3032E40", Offset = "0x3032240", Length = "0x35")]
	[Token(Token = "0x6000C1B")]
	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x886990", Offset = "0x885D90", Length = "0x8D")]
	[Token(Token = "0x6000C1C")]
	public void SetUVs(int channel, NativeArray<T> uvs) { }

	[Address(RVA = "0x3033260", Offset = "0x3032660", Length = "0x83")]
	[Token(Token = "0x6000C0D")]
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x886FE0", Offset = "0x8863E0", Length = "0x162")]
	[Token(Token = "0x6000C08")]
	private void SetUvsImpl(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3033440", Offset = "0x3032840", Length = "0x106")]
	[Token(Token = "0x6000C12")]
	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	[Address(RVA = "0x8876F0", Offset = "0x886AF0", Length = "0x23C")]
	[Token(Token = "0x6000C29")]
	public void SetVertexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x887150", Offset = "0x886550", Length = "0x310")]
	[Token(Token = "0x6000C2B")]
	public void SetVertexBufferData(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x887470", Offset = "0x886870", Length = "0x27C")]
	[Token(Token = "0x6000C2A")]
	public void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	[Address(RVA = "0x30337D0", Offset = "0x3032BD0", Length = "0xE8")]
	[Token(Token = "0x6000C28")]
	public void SetVertexBufferParams(int vertexCount, NativeArray<VertexAttributeDescriptor> attributes) { }

	[Address(RVA = "0x30335A0", Offset = "0x30329A0", Length = "0x112")]
	[Token(Token = "0x6000C27")]
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[Address(RVA = "0x30335A0", Offset = "0x30329A0", Length = "0x112")]
	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B42")]
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[Address(RVA = "0x3033550", Offset = "0x3032950", Length = "0x50")]
	[Token(Token = "0x6000CB9")]
	private static void SetVertexBufferParamsFromArray_Injected(IntPtr _unity_self, int vertexCount, ref ManagedSpanWrapper attributes) { }

	[Address(RVA = "0x3033720", Offset = "0x3032B20", Length = "0xA7")]
	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromPtr", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000B41")]
	private void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount) { }

	[Address(RVA = "0x30336C0", Offset = "0x3032AC0", Length = "0x60")]
	[Token(Token = "0x6000CB8")]
	private static void SetVertexBufferParamsFromPtr_Injected(IntPtr _unity_self, int vertexCount, IntPtr attributesPtr, int attributesCount) { }

	[Address(RVA = "0x3033940", Offset = "0x3032D40", Length = "0x79")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BDB")]
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	[Address(RVA = "0x3033B50", Offset = "0x3032F50", Length = "0x6E")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BDE")]
	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	[Address(RVA = "0x3033AB0", Offset = "0x3032EB0", Length = "0x96")]
	[Token(Token = "0x6000BDA")]
	public void SetVertices(List<Vector3> inVertices) { }

	[Address(RVA = "0x884AA0", Offset = "0x883EA0", Length = "0x7E")]
	[Token(Token = "0x6000BE0")]
	public void SetVertices(NativeArray<T> inVertices) { }

	[Address(RVA = "0x884C80", Offset = "0x884080", Length = "0x86")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000BE1")]
	public void SetVertices(NativeArray<T> inVertices, int start, int length) { }

	[Address(RVA = "0x887D70", Offset = "0x887170", Length = "0x127")]
	[Token(Token = "0x6000BE2")]
	public void SetVertices(NativeArray<T> inVertices, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x30339C0", Offset = "0x3032DC0", Length = "0x6A")]
	[Token(Token = "0x6000BDD")]
	public void SetVertices(Vector3[] inVertices) { }

	[Address(RVA = "0x3033A30", Offset = "0x3032E30", Length = "0x79")]
	[Token(Token = "0x6000BDF")]
	public void SetVertices(Vector3[] inVertices, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x30338C0", Offset = "0x3032CC0", Length = "0x79")]
	[Token(Token = "0x6000BDC")]
	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	[Address(RVA = "0x3033CA0", Offset = "0x30330A0", Length = "0xE1")]
	[Token(Token = "0x6000CA8")]
	public void UploadMeshData(bool markNoLongerReadable) { }

	[Address(RVA = "0x3033C10", Offset = "0x3033010", Length = "0x86")]
	[NativeMethod("UploadMeshData")]
	[Token(Token = "0x6000BA5")]
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[Address(RVA = "0x3033BC0", Offset = "0x3032FC0", Length = "0x42")]
	[Token(Token = "0x6000D16")]
	private static void UploadMeshDataImpl_Injected(IntPtr _unity_self, bool markNoLongerReadable) { }

	[Address(RVA = "0x3033D90", Offset = "0x3033190", Length = "0xC8")]
	[Token(Token = "0x6000C8E")]
	private void ValidateCanWriteToLods() { }

	[Address(RVA = "0x3033E60", Offset = "0x3033260", Length = "0x11C")]
	[Token(Token = "0x6000C8C")]
	private void ValidateLodIndex(int level) { }

	[Address(RVA = "0x3033F80", Offset = "0x3033380", Length = "0x124")]
	[Token(Token = "0x6000C8D")]
	private void ValidateSubMeshIndex(int submesh) { }

}

