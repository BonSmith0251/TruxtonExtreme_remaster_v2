namespace UnityEngine;

[NativeAsStruct]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
[NativeType(CodegenOptions::Custom (1), "MonoAnimatorControllerParameter")]
[Token(Token = "0x200001A")]
[UsedByNativeCode]
public class AnimatorControllerParameter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005F")]
	internal string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000060")]
	internal AnimatorControllerParameterType m_Type; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000061")]
	internal float m_DefaultFloat; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000062")]
	internal int m_DefaultInt; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000063")]
	internal bool m_DefaultBool; //Field offset: 0x24

	[Token(Token = "0x1700004B")]
	public string name
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x6000203")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x2FB4870", Offset = "0x2FB3C70", Length = "0x4F")]
	[Token(Token = "0x6000206")]
	public AnimatorControllerParameter() { }

	[Address(RVA = "0x2FB47C0", Offset = "0x2FB3BC0", Length = "0xAF")]
	[Token(Token = "0x6000204")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6000203")]
	public string get_name() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x6000205")]
	public virtual int GetHashCode() { }

}

