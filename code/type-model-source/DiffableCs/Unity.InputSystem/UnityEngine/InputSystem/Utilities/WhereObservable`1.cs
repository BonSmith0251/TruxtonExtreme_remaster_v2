namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x200025E")]
internal class WhereObservable : IObservable<TValue>
{
	[Token(Token = "0x200025F")]
	private class Where : IObserver<TValue>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CC5")]
		private WhereObservable<TValue> m_Observable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CC6")]
		private readonly IObserver<TValue> m_Observer; //Field offset: 0x0

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x60015F9")]
		public Where(WhereObservable<TValue> observable, IObserver<TValue> observer) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60015FA")]
		public override void OnCompleted() { }

		[Address(RVA = "0x153ED50", Offset = "0x153E150", Length = "0x49")]
		[Token(Token = "0x60015FB")]
		public override void OnError(Exception error) { }

		[Address(RVA = "0x153EDA0", Offset = "0x153E1A0", Length = "0xEF")]
		[Token(Token = "0x60015FC")]
		public override void OnNext(TValue evt) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CC3")]
	private readonly IObservable<TValue> m_Source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CC4")]
	private readonly Func<TValue, Boolean> m_Predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60015F7")]
	public WhereObservable`1(IObservable<TValue> source, Func<TValue, Boolean> predicate) { }

	[Address(RVA = "0xF59390", Offset = "0xF58790", Length = "0xCF")]
	[Token(Token = "0x60015F8")]
	public override IDisposable Subscribe(IObserver<TValue> observer) { }

}

