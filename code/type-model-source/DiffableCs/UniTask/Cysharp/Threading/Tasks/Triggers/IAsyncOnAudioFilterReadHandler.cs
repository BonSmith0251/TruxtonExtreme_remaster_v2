namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000182")]
public interface IAsyncOnAudioFilterReadHandler
{

	[Token(Token = "0x60009F5")]
	public UniTask<ValueTuple`2<Single[], Int32>> OnAudioFilterReadAsync() { }

}

