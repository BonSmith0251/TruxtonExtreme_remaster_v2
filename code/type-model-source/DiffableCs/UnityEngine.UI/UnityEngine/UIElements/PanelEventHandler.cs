namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
[Token(Token = "0x2000092")]
public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent, IPointerClickHandler
{
	[Token(Token = "0x2000094")]
	private class PointerEvent : IPointerEvent
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000298")]
		private int <pointerId>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000299")]
		private string <pointerType>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400029A")]
		private bool <isPrimary>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400029B")]
		private int <button>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400029C")]
		private int <pressedButtons>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400029D")]
		private Vector3 <position>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400029E")]
		private Vector3 <localPosition>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400029F")]
		private Vector3 <deltaPosition>k__BackingField; //Field offset: 0x44
		[CompilerGenerated]
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40002A0")]
		private float <deltaTime>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40002A1")]
		private int <clickCount>k__BackingField; //Field offset: 0x54
		[CompilerGenerated]
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40002A2")]
		private float <pressure>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40002A3")]
		private float <tangentialPressure>k__BackingField; //Field offset: 0x5C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40002A4")]
		private float <altitudeAngle>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40002A5")]
		private float <azimuthAngle>k__BackingField; //Field offset: 0x64
		[CompilerGenerated]
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40002A6")]
		private float <twist>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40002A7")]
		private Vector2 <tilt>k__BackingField; //Field offset: 0x6C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40002A8")]
		private PenStatus <penStatus>k__BackingField; //Field offset: 0x74
		[CompilerGenerated]
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40002A9")]
		private Vector2 <radius>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40002AA")]
		private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40002AB")]
		private EventModifiers <modifiers>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x40002AC")]
		private Vector3 <screenPosition>k__BackingField; //Field offset: 0x8C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40002AD")]
		private Vector3 <screenDelta>k__BackingField; //Field offset: 0x98
		[CompilerGenerated]
		[FieldOffset(Offset = "0xA4")]
		[Token(Token = "0x40002AE")]
		private Ray <worldRay>k__BackingField; //Field offset: 0xA4
		[CompilerGenerated]
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40002AF")]
		private UIDocument <document>k__BackingField; //Field offset: 0xC0
		[CompilerGenerated]
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40002B0")]
		private VisualElement <elementTarget>k__BackingField; //Field offset: 0xC8
		[CompilerGenerated]
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40002B1")]
		private VisualElement <elementUnderPointer>k__BackingField; //Field offset: 0xD0

		[Token(Token = "0x17000187")]
		public override bool actionKey
		{
			[Address(RVA = "0x346D920", Offset = "0x346CD20", Length = "0x86")]
			[Token(Token = "0x60005E5")]
			 get { } //Length: 134
		}

		[Token(Token = "0x1700017B")]
		public private override float altitudeAngle
		{
			[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005D1")]
			 get { } //Length: 6
			[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005D2")]
			private set { } //Length: 6
		}

		[Token(Token = "0x17000186")]
		public override bool altKey
		{
			[Address(RVA = "0x346D9B0", Offset = "0x346CDB0", Length = "0xB")]
			[Token(Token = "0x60005E4")]
			 get { } //Length: 11
		}

		[Token(Token = "0x1700017C")]
		public private override float azimuthAngle
		{
			[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005D3")]
			 get { } //Length: 6
			[Address(RVA = "0x121E6F0", Offset = "0x121DAF0", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005D4")]
			private set { } //Length: 6
		}

		[Token(Token = "0x17000172")]
		public private override int button
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005BF")]
			 get { } //Length: 4
			[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005C0")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000178")]
		public private override int clickCount
		{
			[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005CB")]
			 get { } //Length: 4
			[Address(RVA = "0x2592030", Offset = "0x2591430", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005CC")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000185")]
		public override bool commandKey
		{
			[Address(RVA = "0x346D9C0", Offset = "0x346CDC0", Length = "0xB")]
			[Token(Token = "0x60005E3")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000184")]
		public override bool ctrlKey
		{
			[Address(RVA = "0x346D9D0", Offset = "0x346CDD0", Length = "0xB")]
			[Token(Token = "0x60005E2")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000176")]
		public private override Vector3 deltaPosition
		{
			[Address(RVA = "0x346D9E0", Offset = "0x346CDE0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60005C7")]
			 get { } //Length: 19
			[Address(RVA = "0x346DAB0", Offset = "0x346CEB0", Length = "0x10")]
			[CompilerGenerated]
			[Token(Token = "0x60005C8")]
			private set { } //Length: 16
		}

		[Token(Token = "0x17000177")]
		public private override float deltaTime
		{
			[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005C9")]
			 get { } //Length: 6
			[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005CA")]
			private set { } //Length: 6
		}

		[Token(Token = "0x1700018B")]
		public private UIDocument document
		{
			[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60005EC")]
			 get { } //Length: 8
			[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60005ED")]
			private set { } //Length: 19
		}

		[Token(Token = "0x1700018C")]
		public private VisualElement elementTarget
		{
			[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60005EE")]
			 get { } //Length: 8
			[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60005EF")]
			private set { } //Length: 19
		}

		[Token(Token = "0x1700018D")]
		public private VisualElement elementUnderPointer
		{
			[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60005F0")]
			 get { } //Length: 8
			[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60005F1")]
			private set { } //Length: 19
		}

		[Token(Token = "0x17000171")]
		public private override bool isPrimary
		{
			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60005BD")]
			 get { } //Length: 5
			[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005BE")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000175")]
		public private override Vector3 localPosition
		{
			[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60005C5")]
			 get { } //Length: 19
			[Address(RVA = "0x1D14930", Offset = "0x1D13D30", Length = "0x10")]
			[CompilerGenerated]
			[Token(Token = "0x60005C6")]
			private set { } //Length: 16
		}

		[Token(Token = "0x17000182")]
		public private override EventModifiers modifiers
		{
			[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x60005DF")]
			 get { } //Length: 7
			[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x60005E0")]
			private set { } //Length: 7
		}

		[Token(Token = "0x1700017F")]
		public private override PenStatus penStatus
		{
			[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005D9")]
			 get { } //Length: 4
			[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005DA")]
			private set { } //Length: 4
		}

		[Token(Token = "0x1700016F")]
		public private override int pointerId
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[CompilerGenerated]
			[Token(Token = "0x60005B9")]
			 get { } //Length: 85
			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005BA")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000170")]
		public private override string pointerType
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60005BB")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60005BC")]
			private set { } //Length: 13
		}

		[Token(Token = "0x17000174")]
		public private override Vector3 position
		{
			[Address(RVA = "0x2C150E0", Offset = "0x2C144E0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60005C3")]
			 get { } //Length: 19
			[Address(RVA = "0x2F23430", Offset = "0x2F22830", Length = "0x10")]
			[CompilerGenerated]
			[Token(Token = "0x60005C4")]
			private set { } //Length: 16
		}

		[Token(Token = "0x17000173")]
		public private override int pressedButtons
		{
			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005C1")]
			 get { } //Length: 4
			[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60005C2")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000179")]
		public private override float pressure
		{
			[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005CD")]
			 get { } //Length: 6
			[Address(RVA = "0x29E0B50", Offset = "0x29DFF50", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005CE")]
			private set { } //Length: 6
		}

		[Token(Token = "0x17000180")]
		public private override Vector2 radius
		{
			[Address(RVA = "0x346DA20", Offset = "0x346CE20", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60005DB")]
			 get { } //Length: 19
			[Address(RVA = "0x26A6B90", Offset = "0x26A5F90", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60005DC")]
			private set { } //Length: 5
		}

		[Token(Token = "0x17000181")]
		public private override Vector2 radiusVariance
		{
			[Address(RVA = "0x346DA00", Offset = "0x346CE00", Length = "0x19")]
			[CompilerGenerated]
			[Token(Token = "0x60005DD")]
			 get { } //Length: 25
			[Address(RVA = "0x346DAC0", Offset = "0x346CEC0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60005DE")]
			private set { } //Length: 8
		}

		[Token(Token = "0x17000189")]
		public private Vector3 screenDelta
		{
			[Address(RVA = "0x346DA40", Offset = "0x346CE40", Length = "0x19")]
			[CompilerGenerated]
			[Token(Token = "0x60005E8")]
			 get { } //Length: 25
			[Address(RVA = "0x346DAD0", Offset = "0x346CED0", Length = "0x16")]
			[CompilerGenerated]
			[Token(Token = "0x60005E9")]
			private set { } //Length: 22
		}

		[Token(Token = "0x17000188")]
		public private Vector3 screenPosition
		{
			[Address(RVA = "0x346DA60", Offset = "0x346CE60", Length = "0x19")]
			[CompilerGenerated]
			[Token(Token = "0x60005E6")]
			 get { } //Length: 25
			[Address(RVA = "0x346DAF0", Offset = "0x346CEF0", Length = "0x16")]
			[CompilerGenerated]
			[Token(Token = "0x60005E7")]
			private set { } //Length: 22
		}

		[Token(Token = "0x17000183")]
		public override bool shiftKey
		{
			[Address(RVA = "0x346DA80", Offset = "0x346CE80", Length = "0xA")]
			[Token(Token = "0x60005E1")]
			 get { } //Length: 10
		}

		[Token(Token = "0x1700017A")]
		public private override float tangentialPressure
		{
			[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005CF")]
			 get { } //Length: 6
			[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005D0")]
			private set { } //Length: 6
		}

		[Token(Token = "0x1700017E")]
		public private override Vector2 tilt
		{
			[Address(RVA = "0xD11AC0", Offset = "0xD10EC0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60005D7")]
			 get { } //Length: 19
			[Address(RVA = "0xD11C50", Offset = "0xD11050", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60005D8")]
			private set { } //Length: 5
		}

		[Token(Token = "0x1700017D")]
		public private override float twist
		{
			[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005D5")]
			 get { } //Length: 6
			[Address(RVA = "0x16D0CA0", Offset = "0x16D00A0", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x60005D6")]
			private set { } //Length: 6
		}

		[Token(Token = "0x1700018A")]
		public private Ray worldRay
		{
			[Address(RVA = "0x346DA90", Offset = "0x346CE90", Length = "0x1B")]
			[CompilerGenerated]
			[Token(Token = "0x60005EA")]
			 get { } //Length: 27
			[Address(RVA = "0x346DB10", Offset = "0x346CF10", Length = "0x18")]
			[CompilerGenerated]
			[Token(Token = "0x60005EB")]
			private set { } //Length: 24
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005F5")]
		public PointerEvent() { }

		[Address(RVA = "0x346D900", Offset = "0x346CD00", Length = "0x11")]
		[CompilerGenerated]
		[Token(Token = "0x60005F6")]
		internal static bool <Read>g__InRange|114_0(int i, int start, int count) { }

		[Address(RVA = "0x346CC70", Offset = "0x346C070", Length = "0x3F1")]
		[Token(Token = "0x60005F3")]
		public bool ComputeTarget(BaseRuntimePanel panel) { }

		[Address(RVA = "0x346D920", Offset = "0x346CD20", Length = "0x86")]
		[Token(Token = "0x60005E5")]
		public override bool get_actionKey() { }

		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005D1")]
		public override float get_altitudeAngle() { }

		[Address(RVA = "0x346D9B0", Offset = "0x346CDB0", Length = "0xB")]
		[Token(Token = "0x60005E4")]
		public override bool get_altKey() { }

		[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005D3")]
		public override float get_azimuthAngle() { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005BF")]
		public override int get_button() { }

		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005CB")]
		public override int get_clickCount() { }

		[Address(RVA = "0x346D9C0", Offset = "0x346CDC0", Length = "0xB")]
		[Token(Token = "0x60005E3")]
		public override bool get_commandKey() { }

		[Address(RVA = "0x346D9D0", Offset = "0x346CDD0", Length = "0xB")]
		[Token(Token = "0x60005E2")]
		public override bool get_ctrlKey() { }

		[Address(RVA = "0x346D9E0", Offset = "0x346CDE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60005C7")]
		public override Vector3 get_deltaPosition() { }

		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005C9")]
		public override float get_deltaTime() { }

		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60005EC")]
		public UIDocument get_document() { }

		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60005EE")]
		public VisualElement get_elementTarget() { }

		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60005F0")]
		public VisualElement get_elementUnderPointer() { }

		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005BD")]
		public override bool get_isPrimary() { }

		[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60005C5")]
		public override Vector3 get_localPosition() { }

		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60005DF")]
		public override EventModifiers get_modifiers() { }

		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005D9")]
		public override PenStatus get_penStatus() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60005B9")]
		public override int get_pointerId() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005BB")]
		public override string get_pointerType() { }

		[Address(RVA = "0x2C150E0", Offset = "0x2C144E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60005C3")]
		public override Vector3 get_position() { }

		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C1")]
		public override int get_pressedButtons() { }

		[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005CD")]
		public override float get_pressure() { }

		[Address(RVA = "0x346DA20", Offset = "0x346CE20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60005DB")]
		public override Vector2 get_radius() { }

		[Address(RVA = "0x346DA00", Offset = "0x346CE00", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x60005DD")]
		public override Vector2 get_radiusVariance() { }

		[Address(RVA = "0x346DA40", Offset = "0x346CE40", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x60005E8")]
		public Vector3 get_screenDelta() { }

		[Address(RVA = "0x346DA60", Offset = "0x346CE60", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x60005E6")]
		public Vector3 get_screenPosition() { }

		[Address(RVA = "0x346DA80", Offset = "0x346CE80", Length = "0xA")]
		[Token(Token = "0x60005E1")]
		public override bool get_shiftKey() { }

		[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005CF")]
		public override float get_tangentialPressure() { }

		[Address(RVA = "0xD11AC0", Offset = "0xD10EC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60005D7")]
		public override Vector2 get_tilt() { }

		[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005D5")]
		public override float get_twist() { }

		[Address(RVA = "0x346DA90", Offset = "0x346CE90", Length = "0x1B")]
		[CompilerGenerated]
		[Token(Token = "0x60005EA")]
		public Ray get_worldRay() { }

		[Address(RVA = "0x346D070", Offset = "0x346C470", Length = "0x174")]
		[Token(Token = "0x60005F4")]
		private Vector3 GetPanelPosition(VisualElement pickedElement, UIDocument document, Ray worldRay) { }

		[Address(RVA = "0x346D1F0", Offset = "0x346C5F0", Length = "0x707")]
		[Token(Token = "0x60005F2")]
		public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

		[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005D2")]
		private void set_altitudeAngle(float value) { }

		[Address(RVA = "0x121E6F0", Offset = "0x121DAF0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005D4")]
		private void set_azimuthAngle(float value) { }

		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C0")]
		private void set_button(int value) { }

		[Address(RVA = "0x2592030", Offset = "0x2591430", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005CC")]
		private void set_clickCount(int value) { }

		[Address(RVA = "0x346DAB0", Offset = "0x346CEB0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x60005C8")]
		private void set_deltaPosition(Vector3 value) { }

		[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005CA")]
		private void set_deltaTime(float value) { }

		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60005ED")]
		private void set_document(UIDocument value) { }

		[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60005EF")]
		private void set_elementTarget(VisualElement value) { }

		[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60005F1")]
		private void set_elementUnderPointer(VisualElement value) { }

		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005BE")]
		private void set_isPrimary(bool value) { }

		[Address(RVA = "0x1D14930", Offset = "0x1D13D30", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x60005C6")]
		private void set_localPosition(Vector3 value) { }

		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60005E0")]
		private void set_modifiers(EventModifiers value) { }

		[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005DA")]
		private void set_penStatus(PenStatus value) { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005BA")]
		private void set_pointerId(int value) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60005BC")]
		private void set_pointerType(string value) { }

		[Address(RVA = "0x2F23430", Offset = "0x2F22830", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x60005C4")]
		private void set_position(Vector3 value) { }

		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C2")]
		private void set_pressedButtons(int value) { }

		[Address(RVA = "0x29E0B50", Offset = "0x29DFF50", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005CE")]
		private void set_pressure(float value) { }

		[Address(RVA = "0x26A6B90", Offset = "0x26A5F90", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005DC")]
		private void set_radius(Vector2 value) { }

		[Address(RVA = "0x346DAC0", Offset = "0x346CEC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60005DE")]
		private void set_radiusVariance(Vector2 value) { }

		[Address(RVA = "0x346DAD0", Offset = "0x346CED0", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x60005E9")]
		private void set_screenDelta(Vector3 value) { }

		[Address(RVA = "0x346DAF0", Offset = "0x346CEF0", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x60005E7")]
		private void set_screenPosition(Vector3 value) { }

		[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005D0")]
		private void set_tangentialPressure(float value) { }

		[Address(RVA = "0xD11C50", Offset = "0xD11050", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005D8")]
		private void set_tilt(Vector2 value) { }

		[Address(RVA = "0x16D0CA0", Offset = "0x16D00A0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60005D6")]
		private void set_twist(float value) { }

		[Address(RVA = "0x346DB10", Offset = "0x346CF10", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x60005EB")]
		private void set_worldRay(Ray value) { }

	}

	[Token(Token = "0x2000093")]
	private enum PointerEventType : int
	{
		Default = 0,
		Down = 1,
		Up = 2,
	}

	[Token(Token = "0x4000293")]
	private static EventModifiers s_Modifiers; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400028D")]
	private BaseRuntimePanel m_Panel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400028E")]
	private readonly PointerEvent m_PointerEvent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400028F")]
	private readonly List<PointerEventData> m_ContainedPointers; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000290")]
	private float m_LastClickTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000291")]
	private bool m_Selecting; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000292")]
	private Event m_Event; //Field offset: 0x40

	[Token(Token = "0x1700016E")]
	private Focusable currentFocusedElement
	{
		[Address(RVA = "0x3469BE0", Offset = "0x3468FE0", Length = "0x3F")]
		[Token(Token = "0x6000596")]
		private get { } //Length: 63
	}

	[Token(Token = "0x1700016C")]
	private EventSystem eventSystem
	{
		[Address(RVA = "0x3469C20", Offset = "0x3469020", Length = "0xCC")]
		[Token(Token = "0x6000594")]
		private get { } //Length: 204
	}

	[Token(Token = "0x1700016D")]
	private bool isCurrentFocusedPanel
	{
		[Address(RVA = "0x3469CF0", Offset = "0x34690F0", Length = "0xCA")]
		[Token(Token = "0x6000595")]
		private get { } //Length: 202
	}

	[Token(Token = "0x1700016A")]
	public override IPanel panel
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000591")]
		 get { } //Length: 5
		[Address(RVA = "0x3469DE0", Offset = "0x34691E0", Length = "0x99")]
		[Token(Token = "0x6000592")]
		 set { } //Length: 153
	}

	[Token(Token = "0x1700016B")]
	private GameObject selectableGameObject
	{
		[Address(RVA = "0x3469DC0", Offset = "0x34691C0", Length = "0x12")]
		[Token(Token = "0x6000593")]
		private get { } //Length: 18
	}

	[Address(RVA = "0x3469AF0", Offset = "0x3468EF0", Length = "0xE1")]
	[Token(Token = "0x60005B8")]
	public PanelEventHandler() { }

	[Address(RVA = "0x3469BE0", Offset = "0x3468FE0", Length = "0x3F")]
	[Token(Token = "0x6000596")]
	private Focusable get_currentFocusedElement() { }

	[Address(RVA = "0x3469C20", Offset = "0x3469020", Length = "0xCC")]
	[Token(Token = "0x6000594")]
	private EventSystem get_eventSystem() { }

	[Address(RVA = "0x3469CF0", Offset = "0x34690F0", Length = "0xCA")]
	[Token(Token = "0x6000595")]
	private bool get_isCurrentFocusedPanel() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000591")]
	public override IPanel get_panel() { }

	[Address(RVA = "0x3469DC0", Offset = "0x34691C0", Length = "0x12")]
	[Token(Token = "0x6000593")]
	private GameObject get_selectableGameObject() { }

	[Address(RVA = "0x3467570", Offset = "0x3466970", Length = "0xF2")]
	[Token(Token = "0x60005B6")]
	private NavigationDeviceType GetDeviceType(BaseEventData eventData) { }

	[Address(RVA = "0x3467670", Offset = "0x3466A70", Length = "0xA")]
	[Token(Token = "0x60005AD")]
	private void LateUpdate() { }

	[Address(RVA = "0x3467680", Offset = "0x3466A80", Length = "0x1DC")]
	[Token(Token = "0x60005A7")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x3467860", Offset = "0x3466C60", Length = "0x11")]
	[Token(Token = "0x600059F")]
	public override void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x3467880", Offset = "0x3466C80", Length = "0x7")]
	[Token(Token = "0x6000598")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600059D")]
	private void OnElementBlur(BlurEvent e) { }

	[Address(RVA = "0x3467890", Offset = "0x3466C90", Length = "0xA2")]
	[Token(Token = "0x600059C")]
	private void OnElementFocus(FocusEvent e) { }

	[Address(RVA = "0x3467940", Offset = "0x3466D40", Length = "0x7")]
	[Token(Token = "0x6000597")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3467950", Offset = "0x3466D50", Length = "0x23D")]
	[Token(Token = "0x60005A8")]
	public override void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x3467B90", Offset = "0x3466F90", Length = "0x5E")]
	[Token(Token = "0x600059B")]
	private void OnPanelDestroyed() { }

	[Address(RVA = "0x3467BF0", Offset = "0x3466FF0", Length = "0x1B")]
	[Token(Token = "0x60005A5")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x3467C10", Offset = "0x3467010", Length = "0x35D")]
	[Token(Token = "0x60005A2")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x3467F70", Offset = "0x3467370", Length = "0x101")]
	[Token(Token = "0x60005A4")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x3468080", Offset = "0x3467480", Length = "0x357")]
	[Token(Token = "0x60005A3")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x34683E0", Offset = "0x34677E0", Length = "0x15F")]
	[Token(Token = "0x60005A0")]
	public override void OnPointerMove(PointerEventData eventData) { }

	[Address(RVA = "0x3468540", Offset = "0x3467940", Length = "0x1D5")]
	[Token(Token = "0x60005A1")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x3468720", Offset = "0x3467B20", Length = "0x229")]
	[Token(Token = "0x60005A9")]
	public override void OnScroll(PointerEventData eventData) { }

	[Address(RVA = "0x3468950", Offset = "0x3467D50", Length = "0x64")]
	[Token(Token = "0x600059E")]
	public override void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x34689C0", Offset = "0x3467DC0", Length = "0x1DC")]
	[Token(Token = "0x60005A6")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x3468BA0", Offset = "0x3467FA0", Length = "0x1A9")]
	[Token(Token = "0x60005AE")]
	private void ProcessImguiEvents(Focusable target) { }

	[Address(RVA = "0x3468D50", Offset = "0x3468150", Length = "0x81")]
	[Token(Token = "0x60005AF")]
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	[Address(RVA = "0x3468DE0", Offset = "0x34681E0", Length = "0x6E")]
	[Token(Token = "0x60005B0")]
	private void ProcessTabEvent(Event e, Focusable target) { }

	[Address(RVA = "0x3468E50", Offset = "0x3468250", Length = "0x111")]
	[Token(Token = "0x60005B4")]
	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = 0) { }

	[Address(RVA = "0x3468F70", Offset = "0x3468370", Length = "0x1A1")]
	[Token(Token = "0x6000599")]
	private void RegisterCallbacks() { }

	[Address(RVA = "0x3469120", Offset = "0x3468520", Length = "0x65")]
	[Token(Token = "0x60005AA")]
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	[Address(RVA = "0x3469190", Offset = "0x3468590", Length = "0x24")]
	[Token(Token = "0x60005AB")]
	private void SendEvent(EventBase e, Event sourceEvent) { }

	[Address(RVA = "0x34691C0", Offset = "0x34685C0", Length = "0x15F")]
	[Token(Token = "0x60005B3")]
	private void SendKeyDownEvent(Event e, Focusable target) { }

	[Address(RVA = "0x3469320", Offset = "0x3468720", Length = "0x15F")]
	[Token(Token = "0x60005B2")]
	private void SendKeyUpEvent(Event e, Focusable target) { }

	[Address(RVA = "0x3469480", Offset = "0x3468880", Length = "0x13E")]
	[Token(Token = "0x60005B1")]
	private void SendTabEvent(Event e, Direction direction, Focusable target) { }

	[Address(RVA = "0x3469DE0", Offset = "0x34691E0", Length = "0x99")]
	[Token(Token = "0x6000592")]
	public override void set_panel(IPanel value) { }

	[Address(RVA = "0x34695C0", Offset = "0x34689C0", Length = "0x1A1")]
	[Token(Token = "0x600059A")]
	private void UnregisterCallbacks() { }

	[Address(RVA = "0x34699B0", Offset = "0x3468DB0", Length = "0x13B")]
	[Token(Token = "0x60005AC")]
	public void Update() { }

	[Address(RVA = "0x89E0B0", Offset = "0x89D4B0", Length = "0x79")]
	[Token(Token = "0x60005B5")]
	private void UpdatePointerEventTarget(TPointerEvent e, PointerEvent eventData) { }

	[Address(RVA = "0x3469770", Offset = "0x3468B70", Length = "0x232")]
	[Token(Token = "0x60005B7")]
	private void UpdateWorldSpacePointers() { }

}

