namespace UnityEngine;

[NativeHeader("Runtime/Graphics/LOD/LODGroupManager.h")]
[NativeHeader("Runtime/Graphics/LOD/LODUtility.h")]
[NativeHeader("Runtime/Graphics/LOD/LODGroup.h")]
[StaticAccessor("GetLODGroupManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200012A")]
public class LODGroup : Component
{

	[Token(Token = "0x170001D4")]
	public Vector3 localReferencePoint
	{
		[Address(RVA = "0x3020370", Offset = "0x301F770", Length = "0x90")]
		[Token(Token = "0x6000B32")]
		 get { } //Length: 144
	}

	[Token(Token = "0x170001D5")]
	public float size
	{
		[Address(RVA = "0x3020450", Offset = "0x301F850", Length = "0x76")]
		[Token(Token = "0x6000B33")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x3020370", Offset = "0x301F770", Length = "0x90")]
	[Token(Token = "0x6000B32")]
	public Vector3 get_localReferencePoint() { }

	[Address(RVA = "0x3020320", Offset = "0x301F720", Length = "0x42")]
	[Token(Token = "0x6000B35")]
	private static void get_localReferencePoint_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3020450", Offset = "0x301F850", Length = "0x76")]
	[Token(Token = "0x6000B33")]
	public float get_size() { }

	[Address(RVA = "0x3020410", Offset = "0x301F810", Length = "0x33")]
	[Token(Token = "0x6000B36")]
	private static float get_size_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30202A0", Offset = "0x301F6A0", Length = "0x76")]
	[FreeFunction("GetLODs_Binding", HasExplicitThis = True)]
	[Token(Token = "0x6000B34")]
	public LOD[] GetLODs() { }

	[Address(RVA = "0x3020260", Offset = "0x301F660", Length = "0x33")]
	[Token(Token = "0x6000B37")]
	private static LOD[] GetLODs_Injected(IntPtr _unity_self) { }

}

