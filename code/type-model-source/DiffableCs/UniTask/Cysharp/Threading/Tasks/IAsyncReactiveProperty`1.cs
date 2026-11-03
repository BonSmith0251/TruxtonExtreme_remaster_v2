namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000008")]
public interface IAsyncReactiveProperty : IReadOnlyAsyncReactiveProperty<T>, IUniTaskAsyncEnumerable<T>
{

	[Token(Token = "0x17000005")]
	public T Value
	{
		[Token(Token = "0x600001A")]
		 get { } //Length: 0
		[Token(Token = "0x600001B")]
		 set { } //Length: 0
	}

	[Token(Token = "0x600001A")]
	public T get_Value() { }

	[Token(Token = "0x600001B")]
	public void set_Value(T value) { }

}

