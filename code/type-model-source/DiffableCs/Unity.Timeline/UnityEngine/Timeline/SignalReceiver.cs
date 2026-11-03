namespace UnityEngine.Timeline;

[Token(Token = "0x200004A")]
public class SignalReceiver : MonoBehaviour, INotificationReceiver
{
	[Token(Token = "0x200004B")]
	private class EventKeyValue
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000133")]
		private List<SignalAsset> m_Signals; //Field offset: 0x10
		[CustomSignalEventDrawer]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000134")]
		private List<UnityEvent> m_Events; //Field offset: 0x18

		[Token(Token = "0x170000C6")]
		public List<UnityEvent> events
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60002B5")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000C5")]
		public List<SignalAsset> signals
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60002B4")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2F2EBE0", Offset = "0x2F2DFE0", Length = "0xBD")]
		[Token(Token = "0x60002B6")]
		public EventKeyValue() { }

		[Address(RVA = "0x2F2E8B0", Offset = "0x2F2DCB0", Length = "0x133")]
		[Token(Token = "0x60002B1")]
		public void Append(SignalAsset key, UnityEvent value) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60002B5")]
		public List<UnityEvent> get_events() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60002B4")]
		public List<SignalAsset> get_signals() { }

		[Address(RVA = "0x2F2EAA0", Offset = "0x2F2DEA0", Length = "0x7A")]
		[Token(Token = "0x60002B2")]
		public void Remove(int idx) { }

		[Address(RVA = "0x2F2E9F0", Offset = "0x2F2DDF0", Length = "0xA1")]
		[Token(Token = "0x60002B3")]
		public void Remove(SignalAsset key) { }

		[Address(RVA = "0x2F2EB20", Offset = "0x2F2DF20", Length = "0xBC")]
		[Token(Token = "0x60002B0")]
		public bool TryGetValue(SignalAsset key, out UnityEvent value) { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000132")]
	private EventKeyValue m_Events; //Field offset: 0x20

	[Address(RVA = "0x2F32080", Offset = "0x2F31480", Length = "0x10C")]
	[Token(Token = "0x60002AF")]
	public SignalReceiver() { }

	[Address(RVA = "0x2F315E0", Offset = "0x2F309E0", Length = "0x69")]
	[Token(Token = "0x60002A4")]
	public int AddEmptyReaction(UnityEvent reaction) { }

	[Address(RVA = "0x2F31650", Offset = "0x2F30A50", Length = "0x154")]
	[Token(Token = "0x60002A3")]
	public void AddReaction(SignalAsset asset, UnityEvent reaction) { }

	[Address(RVA = "0x2F317B0", Offset = "0x2F30BB0", Length = "0xC4")]
	[Token(Token = "0x60002AB")]
	public void ChangeReactionAtIndex(int idx, UnityEvent reaction) { }

	[Address(RVA = "0x2F31880", Offset = "0x2F30C80", Length = "0x27B")]
	[Token(Token = "0x60002A9")]
	public void ChangeSignalAtIndex(int idx, SignalAsset newKey) { }

	[Address(RVA = "0x2F31B00", Offset = "0x2F30F00", Length = "0x45")]
	[Token(Token = "0x60002A8")]
	public int Count() { }

	[Address(RVA = "0x2F31C10", Offset = "0x2F31010", Length = "0x3C")]
	[Token(Token = "0x60002A7")]
	public UnityEvent GetReaction(SignalAsset key) { }

	[Address(RVA = "0x2F31B50", Offset = "0x2F30F50", Length = "0xB4")]
	[Token(Token = "0x60002AC")]
	public UnityEvent GetReactionAtIndex(int idx) { }

	[Address(RVA = "0x251BAB0", Offset = "0x251AEB0", Length = "0x1B")]
	[Token(Token = "0x60002A6")]
	public IEnumerable<SignalAsset> GetRegisteredSignals() { }

	[Address(RVA = "0x2F31C50", Offset = "0x2F31050", Length = "0xB4")]
	[Token(Token = "0x60002AD")]
	public SignalAsset GetSignalAssetAtIndex(int idx) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002AE")]
	private void OnEnable() { }

	[Address(RVA = "0x2F31D10", Offset = "0x2F31110", Length = "0x11A")]
	[Token(Token = "0x60002A2")]
	public override void OnNotify(Playable origin, INotification notification, object context) { }

	[Address(RVA = "0x2F31F30", Offset = "0x2F31330", Length = "0x144")]
	[Token(Token = "0x60002A5")]
	public void Remove(SignalAsset asset) { }

	[Address(RVA = "0x2F31E30", Offset = "0x2F31230", Length = "0xF9")]
	[Token(Token = "0x60002AA")]
	public void RemoveAtIndex(int idx) { }

}

