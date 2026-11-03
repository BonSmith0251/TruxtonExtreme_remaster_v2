namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000072")]
public interface ITriggerHandler
{

	[Token(Token = "0x1700002F")]
	public ITriggerHandler<T> Next
	{
		[Token(Token = "0x6000188")]
		 get { } //Length: 0
		[Token(Token = "0x6000189")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700002E")]
	public ITriggerHandler<T> Prev
	{
		[Token(Token = "0x6000186")]
		 get { } //Length: 0
		[Token(Token = "0x6000187")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000188")]
	public ITriggerHandler<T> get_Next() { }

	[Token(Token = "0x6000186")]
	public ITriggerHandler<T> get_Prev() { }

	[Token(Token = "0x6000185")]
	public void OnCanceled(CancellationToken cancellationToken) { }

	[Token(Token = "0x6000184")]
	public void OnCompleted() { }

	[Token(Token = "0x6000183")]
	public void OnError(Exception ex) { }

	[Token(Token = "0x6000182")]
	public void OnNext(T value) { }

	[Token(Token = "0x6000189")]
	public void set_Next(ITriggerHandler<T> value) { }

	[Token(Token = "0x6000187")]
	public void set_Prev(ITriggerHandler<T> value) { }

}

