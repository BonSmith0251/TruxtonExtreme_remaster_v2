namespace UnityEngine.Timeline;

[CustomStyle("SignalEmitter")]
[ExcludeFromPreset]
[Token(Token = "0x2000049")]
public class SignalEmitter : Marker, INotification, INotificationOptionProvider
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400012F")]
	private bool m_Retroactive; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	[Token(Token = "0x4000130")]
	private bool m_EmitOnce; //Field offset: 0x29
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000131")]
	private SignalAsset m_Asset; //Field offset: 0x30

	[Token(Token = "0x170000C2")]
	public SignalAsset asset
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600029D")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x600029E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000C1")]
	public bool emitOnce
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x600029B")]
		 get { } //Length: 5
		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[Token(Token = "0x600029C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000C0")]
	public bool retroactive
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000299")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x600029A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000C3")]
	private override PropertyName UnityEngine.Playables.INotification.id
	{
		[Address(RVA = "0x2F31500", Offset = "0x2F30900", Length = "0xAD")]
		[Token(Token = "0x600029F")]
		private get { } //Length: 173
	}

	[Token(Token = "0x170000C4")]
	private override NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags
	{
		[Address(RVA = "0x2F315B0", Offset = "0x2F309B0", Length = "0x25")]
		[Token(Token = "0x60002A0")]
		private get { } //Length: 37
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x60002A1")]
	public SignalEmitter() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600029D")]
	public SignalAsset get_asset() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[Token(Token = "0x600029B")]
	public bool get_emitOnce() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000299")]
	public bool get_retroactive() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x600029E")]
	public void set_asset(SignalAsset value) { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[Token(Token = "0x600029C")]
	public void set_emitOnce(bool value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x600029A")]
	public void set_retroactive(bool value) { }

	[Address(RVA = "0x2F31500", Offset = "0x2F30900", Length = "0xAD")]
	[Token(Token = "0x600029F")]
	private override PropertyName UnityEngine.Playables.INotification.get_id() { }

	[Address(RVA = "0x2F315B0", Offset = "0x2F309B0", Length = "0x25")]
	[Token(Token = "0x60002A0")]
	private override NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags() { }

}

