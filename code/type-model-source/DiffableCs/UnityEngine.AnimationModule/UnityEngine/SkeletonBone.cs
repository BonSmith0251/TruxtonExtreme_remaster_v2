namespace UnityEngine;

[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(CodegenOptions::Custom (1), "MonoSkeletonBone")]
[RequiredByNativeCode]
[Token(Token = "0x200001F")]
public struct SkeletonBone
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_Name")]
	[Token(Token = "0x400009E")]
	public string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_ParentName")]
	[Token(Token = "0x400009F")]
	internal string parentName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("m_Position")]
	[Token(Token = "0x40000A0")]
	public Vector3 position; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[NativeName("m_Rotation")]
	[Token(Token = "0x40000A1")]
	public Quaternion rotation; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[NativeName("m_Scale")]
	[Token(Token = "0x40000A2")]
	public Vector3 scale; //Field offset: 0x2C

}

