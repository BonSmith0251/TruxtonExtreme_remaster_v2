namespace DG.Tweening.Core;

[Extension]
[Token(Token = "0x20000AE")]
public static class Extensions
{

	[Address(RVA = "0x7EFD60", Offset = "0x7EF160", Length = "0x1D")]
	[Extension]
	[Token(Token = "0x6000408")]
	public static TweenerCore<T1, T2, TPlugOptions> Blendable(TweenerCore<T1, T2, TPlugOptions> t) { }

	[Address(RVA = "0x7F0DE0", Offset = "0x7F01E0", Length = "0x1D")]
	[Extension]
	[Token(Token = "0x6000409")]
	public static TweenerCore<T1, T2, TPlugOptions> NoFrom(TweenerCore<T1, T2, TPlugOptions> t) { }

	[Address(RVA = "0x7F0E00", Offset = "0x7F0200", Length = "0x1C")]
	[Extension]
	[Token(Token = "0x6000407")]
	public static T SetSpecialStartupMode(T t, SpecialStartupMode mode) { }

}

