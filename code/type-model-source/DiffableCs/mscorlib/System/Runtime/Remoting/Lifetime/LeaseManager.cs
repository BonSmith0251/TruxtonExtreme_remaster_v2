namespace System.Runtime.Remoting.Lifetime;

[Token(Token = "0x200036E")]
internal class LeaseManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E45")]
	private ArrayList _objects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E46")]
	private Timer _timer; //Field offset: 0x18

	[Address(RVA = "0x1EE2DA0", Offset = "0x1EE21A0", Length = "0x66")]
	[Token(Token = "0x6001B8A")]
	public LeaseManager() { }

	[Address(RVA = "0x1EE2610", Offset = "0x1EE1A10", Length = "0x25D")]
	[Token(Token = "0x6001B89")]
	public void ManageLeases(object state) { }

	[Address(RVA = "0x1EE2870", Offset = "0x1EE1C70", Length = "0xD9")]
	[Token(Token = "0x6001B85")]
	public void SetPollTime(TimeSpan timeSpan) { }

	[Address(RVA = "0x1EE2950", Offset = "0x1EE1D50", Length = "0x17A")]
	[Token(Token = "0x6001B87")]
	public void StartManager() { }

	[Address(RVA = "0x1EE2AD0", Offset = "0x1EE1ED0", Length = "0x37")]
	[Token(Token = "0x6001B88")]
	public void StopManager() { }

	[Address(RVA = "0x1EE2B10", Offset = "0x1EE1F10", Length = "0x282")]
	[Token(Token = "0x6001B86")]
	public void TrackLifetime(ServerIdentity identity) { }

}

