namespace Unity.Jobs;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
[MovedFrom(True, "Unity.Entities", "Unity.Entities", null)]
[Token(Token = "0x2000017")]
public class RegisterGenericJobTypeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000D")]
	public Type ConcreteType; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000047")]
	public RegisterGenericJobTypeAttribute(Type type) { }

}

