namespace System;

[Token(Token = "0x20000FB")]
public interface IObserver
{

	[Token(Token = "0x60007B3")]
	public void OnCompleted() { }

	[Token(Token = "0x60007B2")]
	public void OnError(Exception error) { }

	[Token(Token = "0x60007B1")]
	public void OnNext(T value) { }

}

