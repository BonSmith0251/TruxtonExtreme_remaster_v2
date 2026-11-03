namespace UnityEngineInternal;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000008")]
public class TypeInferenceRuleAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000009")]
	private readonly string _rule; //Field offset: 0x10

	[Address(RVA = "0x2FF0070", Offset = "0x2FEF470", Length = "0x78")]
	[Token(Token = "0x6000007")]
	public TypeInferenceRuleAttribute(TypeInferenceRules rule) { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000008")]
	public TypeInferenceRuleAttribute(string rule) { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6000009")]
	public virtual string ToString() { }

}

