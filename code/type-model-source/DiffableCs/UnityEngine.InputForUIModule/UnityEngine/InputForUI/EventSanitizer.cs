namespace UnityEngine.InputForUI;

[Token(Token = "0x200002D")]
internal struct EventSanitizer
{
	[Token(Token = "0x200002E")]
	private interface IEventSanitizer
	{

		[Token(Token = "0x60000F1")]
		public void AfterProviderUpdate() { }

		[Token(Token = "0x60000F0")]
		public void BeforeProviderUpdate() { }

		[Token(Token = "0x60000F2")]
		public void Inspect(in Event ev) { }

		[Token(Token = "0x60000EF")]
		public void Reset() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E1")]
	private IEventSanitizer[] _sanitizers; //Field offset: 0x0

	[Address(RVA = "0x31084A0", Offset = "0x31078A0", Length = "0x120")]
	[Token(Token = "0x60000ED")]
	public void AfterProviderUpdate() { }

	[Address(RVA = "0x31085D0", Offset = "0x31079D0", Length = "0x11F")]
	[Token(Token = "0x60000EC")]
	public void BeforeProviderUpdate() { }

	[Address(RVA = "0x31086F0", Offset = "0x3107AF0", Length = "0x124")]
	[Token(Token = "0x60000EE")]
	public void Inspect(in Event ev) { }

	[Address(RVA = "0x3108820", Offset = "0x3107C20", Length = "0x13B")]
	[Token(Token = "0x60000EB")]
	public void Reset() { }

}

