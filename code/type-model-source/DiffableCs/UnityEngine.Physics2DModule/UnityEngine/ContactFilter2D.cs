namespace UnityEngine;

[NativeClass("ContactFilter", "struct ContactFilter;")]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x200000C")]
public struct ContactFilter2D
{
	[Token(Token = "0x4000023")]
	private static ContactFilter2D _noFilter; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_UseTriggers")]
	[Token(Token = "0x4000024")]
	public bool useTriggers; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[NativeName("m_UseLayerMask")]
	[Token(Token = "0x4000025")]
	public bool useLayerMask; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[NativeName("m_UseDepth")]
	[Token(Token = "0x4000026")]
	public bool useDepth; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[NativeName("m_UseOutsideDepth")]
	[Token(Token = "0x4000027")]
	public bool useOutsideDepth; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[NativeName("m_UseNormalAngle")]
	[Token(Token = "0x4000028")]
	public bool useNormalAngle; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[NativeName("m_UseOutsideNormalAngle")]
	[Token(Token = "0x4000029")]
	public bool useOutsideNormalAngle; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_LayerMask")]
	[Token(Token = "0x400002A")]
	public LayerMask layerMask; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("m_MinDepth")]
	[Token(Token = "0x400002B")]
	public float minDepth; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("m_MaxDepth")]
	[Token(Token = "0x400002C")]
	public float maxDepth; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[NativeName("m_MinNormalAngle")]
	[Token(Token = "0x400002D")]
	public float minNormalAngle; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[NativeName("m_MaxNormalAngle")]
	[Token(Token = "0x400002E")]
	public float maxNormalAngle; //Field offset: 0x18

	[Address(RVA = "0x3124D30", Offset = "0x3124130", Length = "0x7C")]
	[Token(Token = "0x600003D")]
	private static ContactFilter2D() { }

	[Address(RVA = "0x3124AF0", Offset = "0x3123EF0", Length = "0x33")]
	[Token(Token = "0x6000039")]
	private void CheckConsistency() { }

	[Address(RVA = "0x3124B30", Offset = "0x3123F30", Length = "0x160")]
	[Token(Token = "0x600003C")]
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	[Address(RVA = "0x3124C90", Offset = "0x3124090", Length = "0x8C")]
	[Token(Token = "0x600003B")]
	public void SetDepth(float minDepth, float maxDepth) { }

	[Address(RVA = "0x3124D20", Offset = "0x3124120", Length = "0x8")]
	[Token(Token = "0x600003A")]
	public void SetLayerMask(LayerMask layerMask) { }

}

