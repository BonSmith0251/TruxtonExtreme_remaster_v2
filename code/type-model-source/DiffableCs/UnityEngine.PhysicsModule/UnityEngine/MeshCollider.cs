namespace UnityEngine;

[NativeHeader("Modules/Physics/MeshCollider.h")]
[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x200000F")]
public class MeshCollider : Collider
{

	[Token(Token = "0x17000018")]
	public bool convex
	{
		[Address(RVA = "0x31361F0", Offset = "0x31355F0", Length = "0x76")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 118
		[Address(RVA = "0x3136460", Offset = "0x3135860", Length = "0x86")]
		[Token(Token = "0x6000079")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000019")]
	public MeshColliderCookingOptions cookingOptions
	{
		[Address(RVA = "0x31362B0", Offset = "0x31356B0", Length = "0x76")]
		[Token(Token = "0x600007A")]
		 get { } //Length: 118
		[Address(RVA = "0x3136530", Offset = "0x3135930", Length = "0x83")]
		[Token(Token = "0x600007B")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000017")]
	public Mesh sharedMesh
	{
		[Address(RVA = "0x3136370", Offset = "0x3135770", Length = "0x90")]
		[Token(Token = "0x6000076")]
		 get { } //Length: 144
		[Address(RVA = "0x3136610", Offset = "0x3135A10", Length = "0xBA")]
		[Token(Token = "0x6000077")]
		 set { } //Length: 186
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600007C")]
	public MeshCollider() { }

	[Address(RVA = "0x31361F0", Offset = "0x31355F0", Length = "0x76")]
	[Token(Token = "0x6000078")]
	public bool get_convex() { }

	[Address(RVA = "0x31361B0", Offset = "0x31355B0", Length = "0x33")]
	[Token(Token = "0x600007F")]
	private static bool get_convex_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31362B0", Offset = "0x31356B0", Length = "0x76")]
	[Token(Token = "0x600007A")]
	public MeshColliderCookingOptions get_cookingOptions() { }

	[Address(RVA = "0x3136270", Offset = "0x3135670", Length = "0x33")]
	[Token(Token = "0x6000081")]
	private static MeshColliderCookingOptions get_cookingOptions_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3136370", Offset = "0x3135770", Length = "0x90")]
	[Token(Token = "0x6000076")]
	public Mesh get_sharedMesh() { }

	[Address(RVA = "0x3136330", Offset = "0x3135730", Length = "0x33")]
	[Token(Token = "0x600007D")]
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3136460", Offset = "0x3135860", Length = "0x86")]
	[Token(Token = "0x6000079")]
	public void set_convex(bool value) { }

	[Address(RVA = "0x3136410", Offset = "0x3135810", Length = "0x42")]
	[Token(Token = "0x6000080")]
	private static void set_convex_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3136530", Offset = "0x3135930", Length = "0x83")]
	[Token(Token = "0x600007B")]
	public void set_cookingOptions(MeshColliderCookingOptions value) { }

	[Address(RVA = "0x31364F0", Offset = "0x31358F0", Length = "0x40")]
	[Token(Token = "0x6000082")]
	private static void set_cookingOptions_Injected(IntPtr _unity_self, MeshColliderCookingOptions value) { }

	[Address(RVA = "0x3136610", Offset = "0x3135A10", Length = "0xBA")]
	[Token(Token = "0x6000077")]
	public void set_sharedMesh(Mesh value) { }

	[Address(RVA = "0x31365C0", Offset = "0x31359C0", Length = "0x42")]
	[Token(Token = "0x600007E")]
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

}

