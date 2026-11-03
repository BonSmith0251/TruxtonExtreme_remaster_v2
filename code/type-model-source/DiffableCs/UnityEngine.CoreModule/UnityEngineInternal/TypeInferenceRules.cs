namespace UnityEngineInternal;

[Token(Token = "0x2000007")]
public enum TypeInferenceRules : int
{
	TypeReferencedByFirstArgument = 0,
	TypeReferencedBySecondArgument = 1,
	ArrayOfTypeReferencedByFirstArgument = 2,
	TypeOfFirstArgument = 3,
}

