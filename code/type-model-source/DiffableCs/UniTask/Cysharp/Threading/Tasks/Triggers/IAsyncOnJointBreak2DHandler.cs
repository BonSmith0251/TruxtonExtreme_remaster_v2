namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001A6")]
public interface IAsyncOnJointBreak2DHandler
{

	[Token(Token = "0x6000A73")]
	public UniTask<Joint2D> OnJointBreak2DAsync() { }

}

