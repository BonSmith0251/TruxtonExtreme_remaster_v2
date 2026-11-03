namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000EE")]
public enum DelayType : int
{
	DeltaTime = 0,
	UnscaledDeltaTime = 1,
	Realtime = 2,
}

