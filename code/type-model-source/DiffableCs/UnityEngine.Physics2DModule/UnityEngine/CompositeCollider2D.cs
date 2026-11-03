namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/CompositeCollider2D.h")]
[RequireComponent(typeof(Rigidbody2D))]
[Token(Token = "0x2000017")]
public sealed class CompositeCollider2D : Collider2D
{

	[Token(Token = "0x17000028")]
	public int pathCount
	{
		[Address(RVA = "0x3124420", Offset = "0x3123820", Length = "0x76")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000029")]
	public int pointCount
	{
		[Address(RVA = "0x31244E0", Offset = "0x31238E0", Length = "0x76")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x3124420", Offset = "0x3123820", Length = "0x76")]
	[Token(Token = "0x6000094")]
	public int get_pathCount() { }

	[Address(RVA = "0x31243E0", Offset = "0x31237E0", Length = "0x33")]
	[Token(Token = "0x6000098")]
	private static int get_pathCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31244E0", Offset = "0x31238E0", Length = "0x76")]
	[Token(Token = "0x6000095")]
	public int get_pointCount() { }

	[Address(RVA = "0x31244A0", Offset = "0x31238A0", Length = "0x33")]
	[Token(Token = "0x6000099")]
	private static int get_pointCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3124160", Offset = "0x3123560", Length = "0x276")]
	[Token(Token = "0x6000096")]
	public int GetPath(int index, Vector2[] points) { }

	[Address(RVA = "0x3124020", Offset = "0x3123420", Length = "0x134")]
	[NativeMethod("GetPathArray_Binding")]
	[Token(Token = "0x6000097")]
	private int GetPathArray_Internal(int index, Vector2[] points) { }

	[Address(RVA = "0x3123FD0", Offset = "0x31233D0", Length = "0x50")]
	[Token(Token = "0x600009A")]
	private static int GetPathArray_Internal_Injected(IntPtr _unity_self, int index, ref ManagedSpanWrapper points) { }

}

