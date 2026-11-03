namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001A4")]
public interface IAsyncOnJointBreakHandler
{

	[Token(Token = "0x6000A6C")]
	public UniTask<Single> OnJointBreakAsync() { }

}

