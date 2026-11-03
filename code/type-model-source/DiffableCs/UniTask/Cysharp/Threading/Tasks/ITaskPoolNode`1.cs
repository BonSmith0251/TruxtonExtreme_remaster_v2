namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200006F")]
public interface ITaskPoolNode
{

	[Token(Token = "0x1700002C")]
	public T NextNode
	{
		[Token(Token = "0x6000175")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000175")]
	public T get_NextNode() { }

}

