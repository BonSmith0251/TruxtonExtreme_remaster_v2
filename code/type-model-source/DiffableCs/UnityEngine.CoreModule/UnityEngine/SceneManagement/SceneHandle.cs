namespace UnityEngine.SceneManagement;

[NativeClass("UnitySceneHandle")]
[NativeHeader("Runtime/SceneManager/UnitySceneHandle.h")]
[Token(Token = "0x200025F")]
[UsedByNativeCode]
public struct SceneHandle : IEquatable<SceneHandle>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007CF")]
	internal EntityId m_Value; //Field offset: 0x0

	[Address(RVA = "0x3086470", Offset = "0x3085870", Length = "0x83")]
	[Token(Token = "0x6001860")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3086460", Offset = "0x3085860", Length = "0xA")]
	[Token(Token = "0x6001861")]
	public override bool Equals(SceneHandle other) { }

	[Address(RVA = "0x3086500", Offset = "0x3085900", Length = "0x7")]
	[Token(Token = "0x6001863")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3086520", Offset = "0x3085920", Length = "0x8")]
	[Token(Token = "0x6001862")]
	public static bool op_Equality(SceneHandle left, SceneHandle right) { }

	[Address(RVA = "0x3086510", Offset = "0x3085910", Length = "0x7")]
	[Token(Token = "0x6001864")]
	public virtual string ToString() { }

}

