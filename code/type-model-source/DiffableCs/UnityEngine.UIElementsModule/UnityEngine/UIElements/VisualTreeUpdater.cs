namespace UnityEngine.UIElements;

[Token(Token = "0x2000567")]
internal sealed class VisualTreeUpdater : IDisposable
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000568")]
	private class UpdaterArray
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011FC")]
		private IVisualTreeUpdater[] m_VisualTreeUpdaters; //Field offset: 0x10

		[Token(Token = "0x17000A24")]
		public IVisualTreeUpdater Item
		{
			[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
			[Token(Token = "0x6002766")]
			 get { } //Length: 43
			[Address(RVA = "0x32E5E20", Offset = "0x32E5220", Length = "0x7B")]
			[Token(Token = "0x6002765")]
			 set { } //Length: 123
		}

		[Token(Token = "0x17000A25")]
		public IVisualTreeUpdater Item
		{
			[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
			[Token(Token = "0x6002767")]
			 get { } //Length: 43
		}

		[Address(RVA = "0x32E5DC0", Offset = "0x32E51C0", Length = "0x55")]
		[Token(Token = "0x6002764")]
		public UpdaterArray() { }

		[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
		[Token(Token = "0x6002766")]
		public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

		[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
		[Token(Token = "0x6002767")]
		public IVisualTreeUpdater get_Item(int index) { }

		[Address(RVA = "0x32E5E20", Offset = "0x32E5220", Length = "0x7B")]
		[Token(Token = "0x6002765")]
		public void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011FA")]
	private BaseVisualElementPanel m_Panel; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011FB")]
	private UpdaterArray m_UpdaterArray; //Field offset: 0x18

	[Address(RVA = "0x32ED6F0", Offset = "0x32ECAF0", Length = "0x1C3")]
	[Token(Token = "0x600275C")]
	public VisualTreeUpdater(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x32ECFA0", Offset = "0x32EC3A0", Length = "0x122")]
	[Token(Token = "0x600275D")]
	public override void Dispose() { }

	[Address(RVA = "0x32ED0D0", Offset = "0x32EC4D0", Length = "0x33")]
	[Token(Token = "0x6002762")]
	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x32ED110", Offset = "0x32EC510", Length = "0x134")]
	[Token(Token = "0x600275F")]
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x32ED250", Offset = "0x32EC650", Length = "0x11B")]
	[Token(Token = "0x6002763")]
	private void SetDefaultUpdaters() { }

	[Address(RVA = "0x32ED370", Offset = "0x32EC770", Length = "0x175")]
	[Token(Token = "0x6002760")]
	public void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x9E5830", Offset = "0x9E4C30", Length = "0x136")]
	[Token(Token = "0x6002761")]
	public void SetUpdater(VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x32ED4F0", Offset = "0x32EC8F0", Length = "0x1FC")]
	[Token(Token = "0x600275E")]
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

}

