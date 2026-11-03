namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000039")]
public enum UniTaskStatus : int
{
	Pending = 0,
	Succeeded = 1,
	Faulted = 2,
	Canceled = 3,
}

