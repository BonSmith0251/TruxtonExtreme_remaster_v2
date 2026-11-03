namespace UnityEngine.Serialization;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = True, Inherited = False)]
[RequiredByNativeCode]
[Token(Token = "0x200024B")]
public class FormerlySerializedAsAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B1")]
	private string m_oldName; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x600182D")]
	public FormerlySerializedAsAttribute(string oldName) { }

}

