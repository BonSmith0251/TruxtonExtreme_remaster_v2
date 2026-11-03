namespace UnityEngine;

[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
[StaticAccessor("GizmoBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x20000CE")]
public sealed class Gizmos
{

	[Token(Token = "0x1700010C")]
	public static Color color
	{
		[Address(RVA = "0x2FF3BC0", Offset = "0x2FF2FC0", Length = "0x33")]
		[Token(Token = "0x6000608")]
		 set { } //Length: 51
	}

	[Token(Token = "0x1700010D")]
	public static Matrix4x4 matrix
	{
		[Address(RVA = "0x2FF3C40", Offset = "0x2FF3040", Length = "0x33")]
		[Token(Token = "0x6000609")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x2FF3800", Offset = "0x2FF2C00", Length = "0x19D")]
	[NativeThrows]
	[Token(Token = "0x6000607")]
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	[Address(RVA = "0x2FF3790", Offset = "0x2FF2B90", Length = "0x64")]
	[Token(Token = "0x600060D")]
	private static void DrawIcon_Injected(in Vector3 center, ref ManagedSpanWrapper name, bool allowScaling, in Color tint) { }

	[Address(RVA = "0x2FF39F0", Offset = "0x2FF2DF0", Length = "0x42")]
	[NativeThrows]
	[Token(Token = "0x6000604")]
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[Address(RVA = "0x2FF39A0", Offset = "0x2FF2DA0", Length = "0x42")]
	[Token(Token = "0x600060A")]
	private static void DrawLine_Injected(in Vector3 from, in Vector3 to) { }

	[Address(RVA = "0x2FF3A90", Offset = "0x2FF2E90", Length = "0x43")]
	[NativeThrows]
	[Token(Token = "0x6000606")]
	public static void DrawSphere(Vector3 center, float radius) { }

	[Address(RVA = "0x2FF3A40", Offset = "0x2FF2E40", Length = "0x43")]
	[Token(Token = "0x600060C")]
	private static void DrawSphere_Injected(in Vector3 center, float radius) { }

	[Address(RVA = "0x2FF3B30", Offset = "0x2FF2F30", Length = "0x43")]
	[NativeThrows]
	[Token(Token = "0x6000605")]
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[Address(RVA = "0x2FF3AE0", Offset = "0x2FF2EE0", Length = "0x43")]
	[Token(Token = "0x600060B")]
	private static void DrawWireSphere_Injected(in Vector3 center, float radius) { }

	[Address(RVA = "0x2FF3BC0", Offset = "0x2FF2FC0", Length = "0x33")]
	[Token(Token = "0x6000608")]
	public static void set_color(Color value) { }

	[Address(RVA = "0x2FF3B80", Offset = "0x2FF2F80", Length = "0x33")]
	[Token(Token = "0x600060E")]
	private static void set_color_Injected(in Color value) { }

	[Address(RVA = "0x2FF3C40", Offset = "0x2FF3040", Length = "0x33")]
	[Token(Token = "0x6000609")]
	public static void set_matrix(Matrix4x4 value) { }

	[Address(RVA = "0x2FF3C00", Offset = "0x2FF3000", Length = "0x33")]
	[Token(Token = "0x600060F")]
	private static void set_matrix_Injected(in Matrix4x4 value) { }

}

