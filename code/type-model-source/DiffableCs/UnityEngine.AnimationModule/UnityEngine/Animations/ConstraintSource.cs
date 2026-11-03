namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
[NativeType(CodegenOptions = CodegenOptions::Custom (1), Header = "Modules/Animation/Constraints/ConstraintSource.h", IntermediateScriptingStructName = "MonoConstraintSource")]
[Token(Token = "0x200003D")]
[UsedByNativeCode]
public struct ConstraintSource
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("sourceTransform")]
	[Token(Token = "0x40000EE")]
	private Transform m_SourceTransform; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("weight")]
	[Token(Token = "0x40000EF")]
	private float m_Weight; //Field offset: 0x8

}

