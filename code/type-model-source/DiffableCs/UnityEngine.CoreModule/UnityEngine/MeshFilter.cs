namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x20000FB")]
public sealed class MeshFilter : Component
{

	[Token(Token = "0x170001C8")]
	public Mesh mesh
	{
		[Address(RVA = "0x3021E10", Offset = "0x3021210", Length = "0x90")]
		[NativeName("GetInstantiatedMeshFromScript")]
		[Token(Token = "0x6000AE5")]
		 get { } //Length: 144
		[Address(RVA = "0x3021FE0", Offset = "0x30213E0", Length = "0xBA")]
		[NativeName("SetInstantiatedMesh")]
		[Token(Token = "0x6000AE6")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170001C7")]
	public Mesh sharedMesh
	{
		[Address(RVA = "0x3021EF0", Offset = "0x30212F0", Length = "0x90")]
		[Token(Token = "0x6000AE3")]
		 get { } //Length: 144
		[Address(RVA = "0x30220F0", Offset = "0x30214F0", Length = "0xBA")]
		[Token(Token = "0x6000AE4")]
		 set { } //Length: 186
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000AE7")]
	public MeshFilter() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000AE2")]
	private void DontStripMeshFilter() { }

	[Address(RVA = "0x3021E10", Offset = "0x3021210", Length = "0x90")]
	[NativeName("GetInstantiatedMeshFromScript")]
	[Token(Token = "0x6000AE5")]
	public Mesh get_mesh() { }

	[Address(RVA = "0x3021DD0", Offset = "0x30211D0", Length = "0x33")]
	[Token(Token = "0x6000AEA")]
	private static IntPtr get_mesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3021EF0", Offset = "0x30212F0", Length = "0x90")]
	[Token(Token = "0x6000AE3")]
	public Mesh get_sharedMesh() { }

	[Address(RVA = "0x3021EB0", Offset = "0x30212B0", Length = "0x33")]
	[Token(Token = "0x6000AE8")]
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3021FE0", Offset = "0x30213E0", Length = "0xBA")]
	[NativeName("SetInstantiatedMesh")]
	[Token(Token = "0x6000AE6")]
	public void set_mesh(Mesh value) { }

	[Address(RVA = "0x3021F90", Offset = "0x3021390", Length = "0x42")]
	[Token(Token = "0x6000AEB")]
	private static void set_mesh_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x30220F0", Offset = "0x30214F0", Length = "0xBA")]
	[Token(Token = "0x6000AE4")]
	public void set_sharedMesh(Mesh value) { }

	[Address(RVA = "0x30220A0", Offset = "0x30214A0", Length = "0x42")]
	[Token(Token = "0x6000AE9")]
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

}

