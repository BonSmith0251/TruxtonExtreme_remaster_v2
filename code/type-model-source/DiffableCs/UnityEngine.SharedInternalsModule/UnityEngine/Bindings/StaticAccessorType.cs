namespace UnityEngine.Bindings;

[Token(Token = "0x2000015")]
[VisibleToOtherModules]
internal enum StaticAccessorType : int
{
	Dot = 0,
	Arrow = 1,
	DoubleColon = 2,
	ArrowWithDefaultReturnIfNull = 3,
}

