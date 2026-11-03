namespace DG.Tweening.Plugins.Core;

[Token(Token = "0x2000093")]
public interface IPlugSetter
{

	[Token(Token = "0x6000368")]
	public T2 EndValue() { }

	[Token(Token = "0x6000369")]
	public TPlugOptions GetOptions() { }

	[Token(Token = "0x6000366")]
	public DOGetter<T1> Getter() { }

	[Token(Token = "0x6000367")]
	public DOSetter<T1> Setter() { }

}

