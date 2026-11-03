namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005C2")]
internal enum ClipMethod : int
{
	Undetermined = 0,
	NotClipped = 1,
	Scissor = 2,
	ShaderDiscard = 3,
	Stencil = 4,
}

